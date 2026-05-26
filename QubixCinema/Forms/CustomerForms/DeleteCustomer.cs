using DevExpress.XtraEditors;
using QubixCinema.Business.Services;
using QubixCinema.DataAccess;
using QubixCinema.Entities.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QubixCinema.Forms.CustomerForms
{
    public partial class DeleteCustomer : Form
    {
        private CustomerService _customerService;
        public DeleteCustomer()
        {
            InitializeComponent();
            _customerService = new CustomerService(new QubixCinemaContext());

        }

        private void DeleteCustomer_Load(object sender, System.EventArgs e)
        {
            try
            {
                LoadCustomers();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Load Error: {ex.ToString()}");
            }
        }

        private void LoadCustomers()
        {
            try
            {
                List<Customer> customers = _customerService.GetAllCustomers();
                grid_customers.DataSource = customers;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Error: {ex.Message}");
                throw;
            }
        }

        private void grid_customers_DoubleClick(object sender, EventArgs e)
        {
            if (grid_customers.CurrentRow?.DataBoundItem is Customer chosenCustomer)
            {
                int customer = chosenCustomer.CustomerId;

                DialogResult result = XtraMessageBox.Show("Are you sure you want to delete the selected customer?",
                     "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _customerService.DeleteCustomer(customer);
                    LoadCustomers();
                    XtraMessageBox.Show("The customer has been successfully removed",
                    "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
