using QubixCinema.DataAccess;
using QubixCinema.Forms.CustomerForms;
using QubixCinema.Forms.MovieForms;
using QubixCinema.Forms.ReservationForms;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace QubixCinema
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Veri tabanı mevcut değilse oluşturur. Mevcut ise hiçbir şey yapmaz,
            // mevcut veri tabanına dokunmaz
            Database.SetInitializer(new CreateDatabaseIfNotExists<QubixCinemaContext>());

            using (var database = new QubixCinemaContext())
            {
                database.Database.Initialize(force: true);
            }
        }

        /// <summary>
        /// A generic manager that opens child forms as unique MDI tabs.
        /// If the requested form is already open, it activates its tab instead of duplicating it.
        /// </summary>
        private void ShowMdiChild<T>() where T : Form, new()
        {
            try
            {
                Form openForm = this.MdiChildren.FirstOrDefault(f => f is T);
                if (openForm != null)
                {
                    openForm.Activate();
                }
                else
                {
                    T newForm = new T();
                    newForm.MdiParent = this;
                    newForm.Show();
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show($"Failed to open view: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bar_button_list_movies_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChild<MovieList>();
        }

        private void bar_button_add_movies_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChild<AddMovie>();
        }

        private void bar_button_update_movies_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChild<UpdateMovie>();
        }

        private void bar_button_delete_movies_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChild<DeleteMovie>();
        }

        private void bar_button_list_customers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChild<CustomerList>();
        }

        private void bar_button_add_customers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChild<AddCustomer>();
        }

        private void bar_button_update_customers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChild<UpdateCustomer>();
        }

        private void bar_button_delete_customers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChild<DeleteCustomer>();
        }

        private void bar_button_view_seats_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChild<Seats>();
        }

        private void bar_button_book_seat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChild<Reservations>();
        }

        private void bar_button_reports_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChild<QubixCinema.Forms.RegisterForms.RegisterReportsForm>();
        }

        private void bar_button_take_payment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            QubixCinema.Forms.RegisterForms.TakePaymentForm tpf = new QubixCinema.Forms.RegisterForms.TakePaymentForm();
            if (tpf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Refresh open reports form if any is currently active in MDI children
                var rrf = this.MdiChildren.OfType<QubixCinema.Forms.RegisterForms.RegisterReportsForm>().FirstOrDefault();
                if (rrf != null)
                {
                    rrf.Close();
                    ShowMdiChild<QubixCinema.Forms.RegisterForms.RegisterReportsForm>();
                }
            }
        }

        private void bar_button_close_day_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (var context = new QubixCinemaContext())
                {
                    var registerService = new QubixCinema.Business.Services.RegisterService(context);
                    decimal dailyRevenue = registerService.GetDailyRevenue();
                    
                    DialogResult confirm = DevExpress.XtraEditors.XtraMessageBox.Show(
                        $"Are you sure you want to CLOSE THE DAY?\nDaily Revenue: ${dailyRevenue:F2} USD.\n\nThis will record a closing log in the cash register.",
                        "End of Day Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirm == DialogResult.Yes)
                    {
                        string result = registerService.CloseDay();
                        DevExpress.XtraEditors.XtraMessageBox.Show(
                            $"Day closed successfully!\n\n{result}",
                            "Day Closed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refresh active reports
                        var rrf = this.MdiChildren.OfType<QubixCinema.Forms.RegisterForms.RegisterReportsForm>().FirstOrDefault();
                        if (rrf != null)
                        {
                            rrf.Close();
                            ShowMdiChild<QubixCinema.Forms.RegisterForms.RegisterReportsForm>();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show($"Failed to close the day: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
