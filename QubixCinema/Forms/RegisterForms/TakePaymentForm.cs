using DevExpress.XtraEditors;
using QubixCinema.Business.Services;
using QubixCinema.DataAccess;
using System;
using System.Windows.Forms;

namespace QubixCinema.Forms.RegisterForms
{
    public partial class TakePaymentForm : XtraForm
    {
        private readonly RegisterService _registerService;

        public TakePaymentForm()
        {
            InitializeComponent();
            _registerService = new RegisterService(new QubixCinemaContext());
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textedit_amount.Text))
            {
                XtraMessageBox.Show("Please enter a valid amount.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textedit_desc.Text))
            {
                XtraMessageBox.Show("Please enter a sales description.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                decimal amount = Convert.ToDecimal(textedit_amount.EditValue);
                if (amount <= 0)
                {
                    XtraMessageBox.Show("Sales amount must be greater than zero.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _registerService.AddTransaction(amount, textedit_desc.Text.Trim() + " (F&B)");

                XtraMessageBox.Show($"Sale processed successfully! Recorded ${amount:F2} USD in the register.", 
                    "Successful Sale", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Failed to process sale: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
