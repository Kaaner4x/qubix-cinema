using DevExpress.XtraEditors;
using QubixCinema.Business.Services;
using QubixCinema.Entities.Models;
using System;
using System.Windows.Forms;

namespace QubixCinema.Forms.CustomerForms
{
    public partial class AddCustomer : Form
    {
        private readonly CustomerService _service;
        public AddCustomer()
        {
            InitializeComponent();
            _service = new CustomerService(new DataAccess.QubixCinemaContext());
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Customer newCustomer = new Customer
            {
                CustomerFirstName = textedit_first_name.Text,
                CustomerLastName = textedit_last_name.Text,
                PhoneNumber = textedit_number.Text,
                Email = textedit_email.Text,
            };

            _service.AddCustomer(newCustomer);

            XtraMessageBox.Show("The customer has been successfully added",
                    "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
