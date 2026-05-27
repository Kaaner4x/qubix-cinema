namespace QubixCinema.Forms.RegisterForms
{
    partial class RegisterReportsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControl_header = new DevExpress.XtraEditors.PanelControl();
            this.panel_total_revenue = new DevExpress.XtraEditors.PanelControl();
            this.lbl_total_revenue_val = new DevExpress.XtraEditors.LabelControl();
            this.lbl_total_revenue_title = new DevExpress.XtraEditors.LabelControl();
            this.panel_daily_revenue = new DevExpress.XtraEditors.PanelControl();
            this.lbl_daily_revenue_val = new DevExpress.XtraEditors.LabelControl();
            this.lbl_daily_revenue_title = new DevExpress.XtraEditors.LabelControl();
            this.panel_transaction_count = new DevExpress.XtraEditors.PanelControl();
            this.lbl_transaction_count_val = new DevExpress.XtraEditors.LabelControl();
            this.lbl_transaction_count_title = new DevExpress.XtraEditors.LabelControl();
            this.gridControl_register = new DevExpress.XtraGrid.GridControl();
            this.gridView_register = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl_header)).BeginInit();
            this.panelControl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_total_revenue)).BeginInit();
            this.panel_total_revenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_daily_revenue)).BeginInit();
            this.panel_daily_revenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_transaction_count)).BeginInit();
            this.panel_transaction_count.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_register)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_register)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl_header
            // 
            this.panelControl_header.Controls.Add(this.panel_transaction_count);
            this.panelControl_header.Controls.Add(this.panel_daily_revenue);
            this.panelControl_header.Controls.Add(this.panel_total_revenue);
            this.panelControl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl_header.Location = new System.Drawing.Point(0, 0);
            this.panelControl_header.Name = "panelControl_header";
            this.panelControl_header.Size = new System.Drawing.Size(950, 110);
            this.panelControl_header.TabIndex = 0;
            // 
            // panel_total_revenue
            // 
            this.panel_total_revenue.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel_total_revenue.Appearance.Options.UseBackColor = true;
            this.panel_total_revenue.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panel_total_revenue.Controls.Add(this.lbl_total_revenue_val);
            this.panel_total_revenue.Controls.Add(this.lbl_total_revenue_title);
            this.panel_total_revenue.Location = new System.Drawing.Point(20, 15);
            this.panel_total_revenue.Name = "panel_total_revenue";
            this.panel_total_revenue.Size = new System.Drawing.Size(280, 80);
            this.panel_total_revenue.TabIndex = 0;
            // 
            // lbl_total_revenue_val
            // 
            this.lbl_total_revenue_val.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_total_revenue_val.Appearance.ForeColor = System.Drawing.Color.White;
            this.lbl_total_revenue_val.Appearance.Options.UseFont = true;
            this.lbl_total_revenue_val.Appearance.Options.UseForeColor = true;
            this.lbl_total_revenue_val.Location = new System.Drawing.Point(15, 35);
            this.lbl_total_revenue_val.Name = "lbl_total_revenue_val";
            this.lbl_total_revenue_val.Size = new System.Drawing.Size(60, 32);
            this.lbl_total_revenue_val.TabIndex = 1;
            this.lbl_total_revenue_val.Text = "$0.00";
            // 
            // lbl_total_revenue_title
            // 
            this.lbl_total_revenue_title.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lbl_total_revenue_title.Appearance.ForeColor = System.Drawing.Color.White;
            this.lbl_total_revenue_title.Appearance.Options.UseFont = true;
            this.lbl_total_revenue_title.Appearance.Options.UseForeColor = true;
            this.lbl_total_revenue_title.Location = new System.Drawing.Point(15, 12);
            this.lbl_total_revenue_title.Name = "lbl_total_revenue_title";
            this.lbl_total_revenue_title.Size = new System.Drawing.Size(107, 17);
            this.lbl_total_revenue_title.TabIndex = 0;
            this.lbl_total_revenue_title.Text = "TOTAL REVENUE";
            // 
            // panel_daily_revenue
            // 
            this.panel_daily_revenue.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.panel_daily_revenue.Appearance.Options.UseBackColor = true;
            this.panel_daily_revenue.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panel_daily_revenue.Controls.Add(this.lbl_daily_revenue_val);
            this.panel_daily_revenue.Controls.Add(this.lbl_daily_revenue_title);
            this.panel_daily_revenue.Location = new System.Drawing.Point(330, 15);
            this.panel_daily_revenue.Name = "panel_daily_revenue";
            this.panel_daily_revenue.Size = new System.Drawing.Size(280, 80);
            this.panel_daily_revenue.TabIndex = 1;
            // 
            // lbl_daily_revenue_val
            // 
            this.lbl_daily_revenue_val.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_daily_revenue_val.Appearance.ForeColor = System.Drawing.Color.White;
            this.lbl_daily_revenue_val.Appearance.Options.UseFont = true;
            this.lbl_daily_revenue_val.Appearance.Options.UseForeColor = true;
            this.lbl_daily_revenue_val.Location = new System.Drawing.Point(15, 35);
            this.lbl_daily_revenue_val.Name = "lbl_daily_revenue_val";
            this.lbl_daily_revenue_val.Size = new System.Drawing.Size(60, 32);
            this.lbl_daily_revenue_val.TabIndex = 1;
            this.lbl_daily_revenue_val.Text = "$0.00";
            // 
            // lbl_daily_revenue_title
            // 
            this.lbl_daily_revenue_title.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lbl_daily_revenue_title.Appearance.ForeColor = System.Drawing.Color.White;
            this.lbl_daily_revenue_title.Appearance.Options.UseFont = true;
            this.lbl_daily_revenue_title.Appearance.Options.UseForeColor = true;
            this.lbl_daily_revenue_title.Location = new System.Drawing.Point(15, 12);
            this.lbl_daily_revenue_title.Name = "lbl_daily_revenue_title";
            this.lbl_daily_revenue_title.Size = new System.Drawing.Size(104, 17);
            this.lbl_daily_revenue_title.TabIndex = 0;
            this.lbl_daily_revenue_title.Text = "DAILY REVENUE";
            // 
            // panel_transaction_count
            // 
            this.panel_transaction_count.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.panel_transaction_count.Appearance.Options.UseBackColor = true;
            this.panel_transaction_count.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panel_transaction_count.Controls.Add(this.lbl_transaction_count_val);
            this.panel_transaction_count.Controls.Add(this.lbl_transaction_count_title);
            this.panel_transaction_count.Location = new System.Drawing.Point(640, 15);
            this.panel_transaction_count.Name = "panel_transaction_count";
            this.panel_transaction_count.Size = new System.Drawing.Size(280, 80);
            this.panel_transaction_count.TabIndex = 2;
            // 
            // lbl_transaction_count_val
            // 
            this.lbl_transaction_count_val.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_transaction_count_val.Appearance.ForeColor = System.Drawing.Color.White;
            this.lbl_transaction_count_val.Appearance.Options.UseFont = true;
            this.lbl_transaction_count_val.Appearance.Options.UseForeColor = true;
            this.lbl_transaction_count_val.Location = new System.Drawing.Point(15, 35);
            this.lbl_transaction_count_val.Name = "lbl_transaction_count_val";
            this.lbl_transaction_count_val.Size = new System.Drawing.Size(14, 32);
            this.lbl_transaction_count_val.TabIndex = 1;
            this.lbl_transaction_count_val.Text = "0";
            // 
            // lbl_transaction_count_title
            // 
            this.lbl_transaction_count_title.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lbl_transaction_count_title.Appearance.ForeColor = System.Drawing.Color.White;
            this.lbl_transaction_count_title.Appearance.Options.UseFont = true;
            this.lbl_transaction_count_title.Appearance.Options.UseForeColor = true;
            this.lbl_transaction_count_title.Location = new System.Drawing.Point(15, 12);
            this.lbl_transaction_count_title.Name = "lbl_transaction_count_title";
            this.lbl_transaction_count_title.Size = new System.Drawing.Size(142, 17);
            this.lbl_transaction_count_title.TabIndex = 0;
            this.lbl_transaction_count_title.Text = "TOTAL TRANSACTIONS";
            // 
            // gridControl_register
            // 
            this.gridControl_register.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_register.Location = new System.Drawing.Point(0, 110);
            this.gridControl_register.MainView = this.gridView_register;
            this.gridControl_register.Name = "gridControl_register";
            this.gridControl_register.Size = new System.Drawing.Size(950, 440);
            this.gridControl_register.TabIndex = 1;
            this.gridControl_register.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_register});
            // 
            // gridView_register
            // 
            this.gridView_register.GridControl = this.gridControl_register;
            this.gridView_register.Name = "gridView_register";
            this.gridView_register.OptionsBehavior.Editable = false;
            this.gridView_register.OptionsView.ShowGroupPanel = false;
            // 
            // RegisterReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 550);
            this.Controls.Add(this.gridControl_register);
            this.Controls.Add(this.panelControl_header);
            this.Name = "RegisterReportsForm";
            this.Text = "Cash Register Business Analytics & POS Reports";
            this.Load += new System.EventHandler(this.RegisterReportsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl_header)).EndInit();
            this.panelControl_header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel_total_revenue)).EndInit();
            this.panel_total_revenue.ResumeLayout(false);
            this.panel_total_revenue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_daily_revenue)).EndInit();
            this.panel_daily_revenue.ResumeLayout(false);
            this.panel_daily_revenue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_transaction_count)).EndInit();
            this.panel_transaction_count.ResumeLayout(false);
            this.panel_transaction_count.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_register)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_register)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl_header;
        private DevExpress.XtraEditors.PanelControl panel_total_revenue;
        private DevExpress.XtraEditors.LabelControl lbl_total_revenue_val;
        private DevExpress.XtraEditors.LabelControl lbl_total_revenue_title;
        private DevExpress.XtraEditors.PanelControl panel_daily_revenue;
        private DevExpress.XtraEditors.LabelControl lbl_daily_revenue_val;
        private DevExpress.XtraEditors.LabelControl lbl_daily_revenue_title;
        private DevExpress.XtraEditors.PanelControl panel_transaction_count;
        private DevExpress.XtraEditors.LabelControl lbl_transaction_count_val;
        private DevExpress.XtraEditors.LabelControl lbl_transaction_count_title;
        private DevExpress.XtraGrid.GridControl gridControl_register;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_register;
    }
}
