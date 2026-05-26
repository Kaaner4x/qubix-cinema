using DevExpress.XtraEditors;
using QubixCinema.Business.Services;
using QubixCinema.Entities.Models;
using System;
using System.Windows.Forms;

namespace QubixCinema.Forms.CustomerForms
{
    public partial class UpdateCustomer : Form
    {
        private CustomerService _customerService;
        public UpdateCustomer()
        {
            InitializeComponent();
            _customerService = new CustomerService(new DataAccess.QubixCinemaContext());

        }

        private void UpdateCustomer_Load(object sender, EventArgs e)
        {
            try
            {
                var customers = _customerService.GetAllCustomers();

                combobox_customer.DataSource = customers;
                combobox_customer.DisplayMember = "CustomerFirstName";
                combobox_customer.ValueMember = "CustomerId";
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Load Error: {ex.ToString()}");
            }
        }

        private void combobox_customer_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (combobox_customer.SelectedItem is Customer customer)
            {
                textedit_first_name.Text = customer.CustomerFirstName;
                textedit_last_name.Text = customer.CustomerLastName;
                textedit_email.Text = customer.Email;
                textedit_number.Text = customer.PhoneNumber;
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (combobox_customer.SelectedItem is Customer customer)
            {
                customer.CustomerFirstName = textedit_first_name.Text;
                customer.CustomerLastName = textedit_last_name.Text;
                customer.Email = textedit_email.Text;
                customer.PhoneNumber = textedit_number.Text;

                _customerService.UpdateCustomer(customer);

                XtraMessageBox.Show("The customer has been successfully updated",
                  "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
