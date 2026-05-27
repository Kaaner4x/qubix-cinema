using DevExpress.XtraEditors;
using QubixCinema.Business.Services;
using QubixCinema.DataAccess;
using QubixCinema.Entities.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QubixCinema.Forms.ReservationForms
{
    public partial class Reservations : Form
    {
        private readonly MovieService _movieService;
        private readonly CustomerService _customerService;
        private readonly ReservationService _reservationService;
        private readonly QubixCinemaContext _context;

        private int? _selectedSeatId = null;
        private int? _activeReservationId = null;

        public Reservations()
        {
            InitializeComponent();
            _context = new QubixCinemaContext();
            _movieService = new MovieService(_context);
            _customerService = new CustomerService(_context);
            _reservationService = new ReservationService(_context);

            // Make sure seats exist
            new DatabaseSeeder(_context).SeedSeats();
        }

        private void Reservations_Load(object sender, EventArgs e)
        {
            LoadDropdownData();
        }

        private void LoadDropdownData()
        {
            try
            {
                var movies = _movieService.GetAllMovies();
                combobox_movie.DataSource = movies;
                combobox_movie.DisplayMember = "MovieName";
                combobox_movie.ValueMember = "MovieId";

                var customers = _customerService.GetAllCustomers();

                // Map formatted list to display full names
                var customerList = customers.Select(c => new
                {
                    CustomerId = c.CustomerId,
                    FullName = $"{c.CustomerFirstName} {c.CustomerLastName}"
                }).ToList();

                combobox_customer.DataSource = customerList;
                combobox_customer.DisplayMember = "FullName";
                combobox_customer.ValueMember = "CustomerId";

                // Load cinema halls
                var halls = _context.Seats
                    .Select(s => s.HallName)
                    .Distinct()
                    .OrderBy(h => h)
                    .ToList();

                if (halls.Count > 0)
                {
                    combobox_hall.DataSource = halls;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Failed to load movies, customers, or halls: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void combobox_hall_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combobox_hall.SelectedItem is string selectedHall)
            {
                LoadSeats(selectedHall);
            }
        }

        private void LoadSeats(string hallName)
        {
            try
            {
                flowLayout_seats.Controls.Clear();
                
                // Fetch fresh seat entities for the selected hall
                var seats = _context.Seats
                    .Where(s => s.HallName == hallName)
                    .OrderBy(s => s.SeatNumber)
                    .ToList();

                foreach (var seat in seats)
                {
                    Button seatButton = new Button();

                    seatButton.Text = $"{seat.HallName}\nS: {seat.SerialNumber}\nN: {seat.SeatNumber}";
                    seatButton.Width = 90;
                    seatButton.Height = 70;
                    seatButton.Tag = seat; // Store the seat object
                    seatButton.FlatStyle = FlatStyle.Flat;
                    seatButton.FlatAppearance.BorderSize = 2;
                    seatButton.Font = new Font("Tahoma", 8F, FontStyle.Bold);

                    if (seat.isBooked)
                    {
                        seatButton.BackColor = Color.FromArgb(231, 76, 60); // Red
                        seatButton.ForeColor = Color.White;
                        seatButton.FlatAppearance.BorderColor = Color.FromArgb(192, 57, 43);
                    }
                    else
                    {
                        seatButton.BackColor = Color.FromArgb(46, 204, 113); // Green
                        seatButton.ForeColor = Color.White;
                        seatButton.FlatAppearance.BorderColor = Color.FromArgb(39, 174, 96);
                    }

                    seatButton.Click += SeatButton_Click;
                    flowLayout_seats.Controls.Add(seatButton);
                }

                ResetPanelState();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error loading seats: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SeatButton_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton && clickedButton.Tag is Seat seat)
            {
                // Highlight the selected seat button with a visual border
                foreach (Control ctrl in flowLayout_seats.Controls)
                {
                    if (ctrl is Button btn)
                    {
                        btn.FlatAppearance.BorderSize = 2;
                    }
                }
                clickedButton.FlatAppearance.BorderSize = 4;
                clickedButton.FlatAppearance.BorderColor = Color.FromArgb(41, 128, 185); // Blue border for selection

                _selectedSeatId = seat.SeatId;
                label_selected_seat.Text = $"{seat.HallName} - Row {seat.SerialNumber} - Seat {seat.SeatNumber}";

                if (seat.isBooked)
                {
                    label_seat_status.Text = "BOOKED";
                    label_seat_status.Appearance.ForeColor = Color.Red;

                    // Load booking details
                    var reservation = _reservationService.GetReservationBySeatId(seat.SeatId);
                    if (reservation != null)
                    {
                        _activeReservationId = reservation.ReservationId;
                        label_reservation_details.Text = $"Reserved by: {reservation.Customer?.CustomerFirstName} {reservation.Customer?.CustomerLastName}\n" +
                                                         $"Movie: {reservation.Movie?.MovieName}\n" +
                                                         $"Date: {reservation.ReservationDate:yyyy-MM-dd HH:mm}";

                        btn_cancel_reservation.Visible = true;
                        btn_book_seat.Enabled = false;
                    }
                    else
                    {
                        _activeReservationId = null;
                        label_reservation_details.Text = "Reserved internally (No detailed records found).";
                        btn_cancel_reservation.Visible = false;
                        btn_book_seat.Enabled = false;
                    }
                }
                else
                {
                    _activeReservationId = null;
                    label_seat_status.Text = "AVAILABLE";
                    label_seat_status.Appearance.ForeColor = Color.Green;
                    label_reservation_details.Text = "Seat is available. Select movie and customer to book it for $15.00 USD.";

                    btn_cancel_reservation.Visible = false;
                    btn_book_seat.Enabled = true;
                }
            }
        }

        private void btn_book_seat_Click(object sender, EventArgs e)
        {
            if (_selectedSeatId == null)
            {
                XtraMessageBox.Show("Please select a seat from the visualizer first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (combobox_movie.SelectedValue == null || combobox_customer.SelectedValue == null)
            {
                XtraMessageBox.Show("Please ensure both a movie and a customer are selected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int movieId = (int)combobox_movie.SelectedValue;
                int customerId = (int)combobox_customer.SelectedValue;

                _reservationService.CreateReservation(movieId, customerId, _selectedSeatId.Value, DateTime.Now);

                XtraMessageBox.Show("Ticket booked successfully! Payment of $15.00 USD has been logged to the cash register.", 
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reload layout and data
                if (combobox_hall.SelectedItem is string currentHall)
                {
                    LoadSeats(currentHall);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Booking failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancel_reservation_Click(object sender, EventArgs e)
        {
            if (_activeReservationId == null)
            {
                XtraMessageBox.Show("No active reservation to cancel.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = XtraMessageBox.Show("Are you sure you want to cancel this reservation? A refund of $15.00 USD will be logged in the cash register.", 
                "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    _reservationService.CancelReservation(_activeReservationId.Value);

                    XtraMessageBox.Show("Reservation cancelled and seat has been freed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reload layout and data
                    if (combobox_hall.SelectedItem is string currentHall)
                    {
                        LoadSeats(currentHall);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show($"Cancellation failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ResetPanelState()
        {
            _selectedSeatId = null;
            _activeReservationId = null;
            label_selected_seat.Text = "None Selected";
            label_seat_status.Text = "-";
            label_seat_status.Appearance.ForeColor = Color.Black;
            label_reservation_details.Text = "Click a seat button to view details or book.";
            btn_book_seat.Enabled = false;
            btn_cancel_reservation.Visible = false;
        }
    }
}
