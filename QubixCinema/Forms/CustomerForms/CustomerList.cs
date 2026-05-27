using QubixCinema.Business.Services;
using QubixCinema.DataAccess;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QubixCinema.Forms.CustomerForms
{
    public partial class CustomerList : Form
    {
        private readonly CustomerService _service;
        
        public CustomerList()
        {
            InitializeComponent();
            _service = new CustomerService(new QubixCinemaContext());
        }

        private void LoadCustomers()
        {
            try
            {
                var customers = _service.GetAllCustomers();

                // Hide virtual ICollection relations by projecting to a clean anonymous list
                var displayList = customers.Select(c => new
                {
                    CustomerID = c.CustomerId,
                    FirstName = c.CustomerFirstName,
                    LastName = c.CustomerLastName,
                    PhoneNumber = c.PhoneNumber,
                    Email = c.Email
                }).ToList();

                grid_customers.DataSource = displayList;

                // Auto-fit DevExpress GridView columns
                if (grid_customers.MainView is DevExpress.XtraGrid.Views.Grid.GridView gridView)
                {
                    gridView.BestFitColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customers: {ex.Message}");
            }
        }

        private void CustomerList_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }
    }
}
