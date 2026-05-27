using DevExpress.XtraEditors;
using QubixCinema.DataAccess;
using QubixCinema.Entities.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QubixCinema.Forms.ReservationForms
{
    public partial class Seats : Form
    {
        private readonly QubixCinemaContext _context;

        public Seats()
        {
            InitializeComponent();
            _context = new QubixCinemaContext();
            
            // Ensure seat data exists
            new DatabaseSeeder(_context).SeedSeats();
        }

        private void Seats_Load(object sender, EventArgs e)
        {
            LoadHalls();
        }

        private void LoadHalls()
        {
            try
            {
                // Fetch unique halls from database
                var halls = _context.Seats
                    .Select(s => s.HallName)
                    .Distinct()
                    .OrderBy(h => h)
                    .ToList();

                if (halls.Count > 0)
                {
                    combobox_hall.DataSource = halls;
                }
                else
                {
                    XtraMessageBox.Show("No cinema halls found in the database. Please run the SQL seeding query.", 
                        "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Failed to load cinema halls: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void combobox_hall_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combobox_hall.SelectedItem is string selectedHall)
            {
                RenderHallSeats(selectedHall);
            }
        }

        private void RenderHallSeats(string hallName)
        {
            try
            {
                flowLayout_seats.Controls.Clear();

                // Fetch seats specifically for the selected hall
                var seats = _context.Seats
                    .Where(s => s.HallName == hallName)
                    .OrderBy(s => s.SeatNumber)
                    .ToList();

                int totalSeats = seats.Count;
                int bookedSeats = seats.Count(s => s.isBooked);
                int availableSeats = totalSeats - bookedSeats;

                // Bind KPI metrics
                lbl_total_seats.Text = $"Total Seats: {totalSeats}";
                lbl_available_seats.Text = $"Available: {availableSeats}";
                lbl_booked_seats.Text = $"Booked: {bookedSeats}";

                foreach (var seat in seats)
                {
                    Button seatButton = new Button();

                    seatButton.Text = $"Seat {seat.SeatNumber}\nRow {seat.SerialNumber}";
                    seatButton.Width = 85;
                    seatButton.Height = 65;
                    seatButton.Tag = seat;
                    seatButton.FlatStyle = FlatStyle.Flat;
                    seatButton.FlatAppearance.BorderSize = 2;
                    seatButton.Font = new Font("Tahoma", 8.5F, FontStyle.Bold);

                    if (seat.isBooked)
                    {
                        seatButton.BackColor = Color.FromArgb(231, 76, 60); // Crimson Red
                        seatButton.ForeColor = Color.White;
                        seatButton.FlatAppearance.BorderColor = Color.FromArgb(192, 57, 43);
                    }
                    else
                    {
                        seatButton.BackColor = Color.FromArgb(46, 204, 113); // Emerald Green
                        seatButton.ForeColor = Color.White;
                        seatButton.FlatAppearance.BorderColor = Color.FromArgb(39, 174, 96);
                    }

                    seatButton.Click += SeatButton_Click;
                    flowLayout_seats.Controls.Add(seatButton);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Failed to load seats for {hallName}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SeatButton_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton && clickedButton.Tag is Seat seat)
            {
                string statusText = seat.isBooked ? "BOOKED (Reserved)" : "AVAILABLE (Free)";
                XtraMessageBox.Show($"Seat Details:\nHall: {seat.HallName}\nRow: {seat.SerialNumber}\nSeat Number: {seat.SeatNumber}\nStatus: {statusText}",
                    "Seat Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
