using QubixCinema.Business.Services;
using System;
using System.Windows.Forms;

namespace QubixCinema.Forms.CustomerForms
{
    public partial class CustomerList : Form
    {
        private readonly CustomerService _service;
        public CustomerList()
        {
            InitializeComponent();
            _service = new CustomerService(new DataAccess.QubixCinemaContext());
        }

        private void LoadCustomers()
        {
            var customers = _service.GetAllCustomers();
            grid_customers.DataSource = customers;
        }

        private void CustomerList_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }
    }
}
