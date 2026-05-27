using DevExpress.XtraEditors;
using QubixCinema.Business.Services;
using QubixCinema.DataAccess;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QubixCinema.Forms.RegisterForms
{
    public partial class RegisterReportsForm : XtraForm
    {
        private readonly RegisterService _registerService;

        public RegisterReportsForm()
        {
            InitializeComponent();
            _registerService = new RegisterService(new QubixCinemaContext());
        }

        private void RegisterReportsForm_Load(object sender, EventArgs e)
        {
            LoadAnalytics();
        }

        private void LoadAnalytics()
        {
            try
            {
                // 1. Fetch transactions and bind to GridControl
                var transactions = _registerService.GetAllTransactions();
                
                // Formatted list for better column naming in the Grid
                var displayList = transactions.Select(t => new
                {
                    TransactionID = t.RegisterId,
                    Amount = $"${t.Amount:F2}",
                    Description = t.Description,
                    Date = t.TransactionDate.ToString("yyyy-MM-dd HH:mm:ss")
                }).ToList();

                gridControl_register.DataSource = displayList;

                // Auto-fit grid columns
                gridView_register.BestFitColumns();

                // 2. Compute KPI Metrics
                decimal totalRevenue = _registerService.GetTotalRevenue();
                decimal dailyRevenue = _registerService.GetDailyRevenue();
                int totalTransactions = transactions.Count;

                // 3. Bind to KPI Cards
                lbl_total_revenue_val.Text = $"${totalRevenue:N2}";
                lbl_daily_revenue_val.Text = $"${dailyRevenue:N2}";
                lbl_transaction_count_val.Text = totalTransactions.ToString("N0");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Failed to load financial analytics: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
