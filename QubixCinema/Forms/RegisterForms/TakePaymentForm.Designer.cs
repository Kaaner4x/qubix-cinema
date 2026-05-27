namespace QubixCinema.Forms.RegisterForms
{
    partial class TakePaymentForm
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
            this.groupControl_main = new DevExpress.XtraEditors.GroupControl();
            this.labelControl_amount = new DevExpress.XtraEditors.LabelControl();
            this.textedit_amount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl_desc = new DevExpress.XtraEditors.LabelControl();
            this.textedit_desc = new DevExpress.XtraEditors.TextEdit();
            this.btn_confirm = new DevExpress.XtraEditors.SimpleButton();
            this.btn_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl_symbol = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_main)).BeginInit();
            this.groupControl_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textedit_amount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textedit_desc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl_main
            // 
            this.groupControl_main.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.groupControl_main.AppearanceCaption.Options.UseFont = true;
            this.groupControl_main.Controls.Add(this.labelControl_symbol);
            this.groupControl_main.Controls.Add(this.btn_cancel);
            this.groupControl_main.Controls.Add(this.btn_confirm);
            this.groupControl_main.Controls.Add(this.textedit_desc);
            this.groupControl_main.Controls.Add(this.labelControl_desc);
            this.groupControl_main.Controls.Add(this.textedit_amount);
            this.groupControl_main.Controls.Add(this.labelControl_amount);
            this.groupControl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl_main.Location = new System.Drawing.Point(0, 0);
            this.groupControl_main.Name = "groupControl_main";
            this.groupControl_main.Size = new System.Drawing.Size(434, 251);
            this.groupControl_main.TabIndex = 0;
            this.groupControl_main.Text = "Register Concession / Custom Payment ($)";
            // 
            // labelControl_amount
            // 
            this.labelControl_amount.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.labelControl_amount.Appearance.Options.UseFont = true;
            this.labelControl_amount.Location = new System.Drawing.Point(30, 60);
            this.labelControl_amount.Name = "labelControl_amount";
            this.labelControl_amount.Size = new System.Drawing.Size(89, 16);
            this.labelControl_amount.TabIndex = 0;
            this.labelControl_amount.Text = "Sales Amount:";
            // 
            // textedit_amount
            // 
            this.textedit_amount.Location = new System.Drawing.Point(140, 56);
            this.textedit_amount.Name = "textedit_amount";
            this.textedit_amount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textedit_amount.Properties.Appearance.Options.UseFont = true;
            this.textedit_amount.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.textedit_amount.Properties.MaskSettings.Set("mask", "n2");
            this.textedit_amount.Properties.UseMaskAsDisplayFormat = true;
            this.textedit_amount.Size = new System.Drawing.Size(220, 24);
            this.textedit_amount.TabIndex = 1;
            // 
            // labelControl_desc
            // 
            this.labelControl_desc.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.labelControl_desc.Appearance.Options.UseFont = true;
            this.labelControl_desc.Location = new System.Drawing.Point(30, 110);
            this.labelControl_desc.Name = "labelControl_desc";
            this.labelControl_desc.Size = new System.Drawing.Size(76, 16);
            this.labelControl_desc.TabIndex = 2;
            this.labelControl_desc.Text = "Description:";
            // 
            // textedit_desc
            // 
            this.textedit_desc.Location = new System.Drawing.Point(140, 106);
            this.textedit_desc.Name = "textedit_desc";
            this.textedit_desc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textedit_desc.Properties.Appearance.Options.UseFont = true;
            this.textedit_desc.Properties.MaxLength = 200;
            this.textedit_desc.Size = new System.Drawing.Size(260, 24);
            this.textedit_desc.TabIndex = 3;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_confirm.Appearance.Options.UseFont = true;
            this.btn_confirm.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_confirm.Location = new System.Drawing.Point(30, 170);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(180, 45);
            this.btn_confirm.TabIndex = 4;
            this.btn_confirm.Text = "Process Sale";
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_cancel.Appearance.Options.UseFont = true;
            this.btn_cancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_cancel.Location = new System.Drawing.Point(220, 170);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(180, 45);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // labelControl_symbol
            // 
            this.labelControl_symbol.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl_symbol.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.labelControl_symbol.Appearance.Options.UseFont = true;
            this.labelControl_symbol.Appearance.Options.UseForeColor = true;
            this.labelControl_symbol.Location = new System.Drawing.Point(368, 60);
            this.labelControl_symbol.Name = "labelControl_symbol";
            this.labelControl_symbol.Size = new System.Drawing.Size(26, 16);
            this.labelControl_symbol.TabIndex = 6;
            this.labelControl_symbol.Text = "USD";
            // 
            // TakePaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 251);
            this.Controls.Add(this.groupControl_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TakePaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Register Concession Sale";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_main)).EndInit();
            this.groupControl_main.ResumeLayout(false);
            this.groupControl_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textedit_amount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textedit_desc.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl_main;
        private DevExpress.XtraEditors.LabelControl labelControl_amount;
        private DevExpress.XtraEditors.TextEdit textedit_amount;
        private DevExpress.XtraEditors.LabelControl labelControl_desc;
        private DevExpress.XtraEditors.TextEdit textedit_desc;
        private DevExpress.XtraEditors.SimpleButton btn_confirm;
        private DevExpress.XtraEditors.SimpleButton btn_cancel;
        private DevExpress.XtraEditors.LabelControl labelControl_symbol;
    }
}
