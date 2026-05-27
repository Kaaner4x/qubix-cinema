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
        private readonly CustomerService _customerService;

        public DeleteCustomer()
        {
            InitializeComponent();
            _customerService = new CustomerService(new QubixCinemaContext());
        }

        private void DeleteCustomer_Load(object sender, EventArgs e)
        {
            try
            {
                LoadCustomers();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Load Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCustomers()
        {
            try
            {
                List<Customer> customers = _customerService.GetAllCustomers();
                
                // Hide EF virtual relations by projecting to a clean anonymous list
                var displayList = System.Linq.Enumerable.ToList(
                    System.Linq.Enumerable.Select(customers, c => new
                    {
                        CustomerID = c.CustomerId,
                        FirstName = c.CustomerFirstName,
                        LastName = c.CustomerLastName,
                        Phone = c.PhoneNumber,
                        Email = c.Email
                    })
                );

                grid_customers.DataSource = displayList;
                gridView1.BestFitColumns();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error loading customers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            object customerIdObj = gridView1.GetFocusedRowCellValue("CustomerID");
            if (customerIdObj != null && customerIdObj != DBNull.Value)
            {
                int customerId = Convert.ToInt32(customerIdObj);
                string firstName = Convert.ToString(gridView1.GetFocusedRowCellValue("FirstName"));
                string lastName = Convert.ToString(gridView1.GetFocusedRowCellValue("LastName"));

                DialogResult result = XtraMessageBox.Show($"Are you sure you want to delete customer {firstName} {lastName}?",
                     "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        _customerService.DeleteCustomer(customerId);
                        LoadCustomers();
                        XtraMessageBox.Show("The customer has been successfully removed.",
                            "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show($"Failed to delete customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
