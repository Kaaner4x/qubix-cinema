namespace QubixCinema.Forms.CustomerForms
{
    partial class UpdateCustomer
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
            this.label_customer = new DevExpress.XtraEditors.LabelControl();
            this.combobox_customer = new System.Windows.Forms.ComboBox();
            this.label_first_name = new DevExpress.XtraEditors.LabelControl();
            this.textedit_first_name = new DevExpress.XtraEditors.TextEdit();
            this.label_last_name = new DevExpress.XtraEditors.LabelControl();
            this.textedit_last_name = new DevExpress.XtraEditors.TextEdit();
            this.label_email = new DevExpress.XtraEditors.LabelControl();
            this.textedit_email = new DevExpress.XtraEditors.TextEdit();
            this.label_number = new DevExpress.XtraEditors.LabelControl();
            this.textedit_number = new DevExpress.XtraEditors.TextEdit();
            this.button_update = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_main)).BeginInit();
            this.groupControl_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textedit_first_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textedit_last_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textedit_email.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textedit_number.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl_main
            // 
            this.groupControl_main.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.groupControl_main.AppearanceCaption.Options.UseFont = true;
            this.groupControl_main.Controls.Add(this.button_update);
            this.groupControl_main.Controls.Add(this.textedit_number);
            this.groupControl_main.Controls.Add(this.label_number);
            this.groupControl_main.Controls.Add(this.textedit_email);
            this.groupControl_main.Controls.Add(this.label_email);
            this.groupControl_main.Controls.Add(this.textedit_last_name);
            this.groupControl_main.Controls.Add(this.label_last_name);
            this.groupControl_main.Controls.Add(this.textedit_first_name);
            this.groupControl_main.Controls.Add(this.label_first_name);
            this.groupControl_main.Controls.Add(this.combobox_customer);
            this.groupControl_main.Controls.Add(this.label_customer);
            this.groupControl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl_main.Location = new System.Drawing.Point(0, 0);
            this.groupControl_main.Name = "groupControl_main";
            this.groupControl_main.Size = new System.Drawing.Size(520, 410);
            this.groupControl_main.TabIndex = 0;
            this.groupControl_main.Text = "Update Customer Information Profile";
            // 
            // label_customer
            // 
            this.label_customer.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.label_customer.Appearance.Options.UseFont = true;
            this.label_customer.Location = new System.Drawing.Point(40, 60);
            this.label_customer.Name = "label_customer";
            this.label_customer.Size = new System.Drawing.Size(112, 16);
            this.label_customer.TabIndex = 0;
            this.label_customer.Text = "Select Customer:";
            // 
            // combobox_customer
            // 
            this.combobox_customer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_customer.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.combobox_customer.FormattingEnabled = true;
            this.combobox_customer.Location = new System.Drawing.Point(170, 56);
            this.combobox_customer.Name = "combobox_customer";
            this.combobox_customer.Size = new System.Drawing.Size(290, 24);
            this.combobox_customer.TabIndex = 1;
            this.combobox_customer.SelectedIndexChanged += new System.EventHandler(this.combobox_customer_SelectedIndexChanged);
            // 
            // label_first_name
            // 
            this.label_first_name.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.label_first_name.Appearance.Options.UseFont = true;
            this.label_first_name.Location = new System.Drawing.Point(40, 115);
            this.label_first_name.Name = "label_first_name";
            this.label_first_name.Size = new System.Drawing.Size(73, 16);
            this.label_first_name.TabIndex = 2;
            this.label_first_name.Text = "First Name:";
            // 
            // textedit_first_name
            // 
            this.textedit_first_name.Location = new System.Drawing.Point(170, 111);
            this.textedit_first_name.Name = "textedit_first_name";
            this.textedit_first_name.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textedit_first_name.Properties.Appearance.Options.UseFont = true;
            this.textedit_first_name.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.textedit_first_name.Size = new System.Drawing.Size(290, 24);
            this.textedit_first_name.TabIndex = 3;
            // 
            // label_last_name
            // 
            this.label_last_name.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.label_last_name.Appearance.Options.UseFont = true;
            this.label_last_name.Location = new System.Drawing.Point(40, 165);
            this.label_last_name.Name = "label_last_name";
            this.label_last_name.Size = new System.Drawing.Size(71, 16);
            this.label_last_name.TabIndex = 4;
            this.label_last_name.Text = "Last Name:";
            // 
            // textedit_last_name
            // 
            this.textedit_last_name.Location = new System.Drawing.Point(170, 161);
            this.textedit_last_name.Name = "textedit_last_name";
            this.textedit_last_name.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textedit_last_name.Properties.Appearance.Options.UseFont = true;
            this.textedit_last_name.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.textedit_last_name.Size = new System.Drawing.Size(290, 24);
            this.textedit_last_name.TabIndex = 5;
            // 
            // label_email
            // 
            this.label_email.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.label_email.Appearance.Options.UseFont = true;
            this.label_email.Location = new System.Drawing.Point(40, 215);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(39, 16);
            this.label_email.TabIndex = 6;
            this.label_email.Text = "Email:";
            // 
            // textedit_email
            // 
            this.textedit_email.Location = new System.Drawing.Point(170, 211);
            this.textedit_email.Name = "textedit_email";
            this.textedit_email.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textedit_email.Properties.Appearance.Options.UseFont = true;
            this.textedit_email.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.textedit_email.Size = new System.Drawing.Size(290, 24);
            this.textedit_email.TabIndex = 7;
            // 
            // label_number
            // 
            this.label_number.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.label_number.Appearance.Options.UseFont = true;
            this.label_number.Location = new System.Drawing.Point(40, 265);
            this.label_number.Name = "label_number";
            this.label_number.Size = new System.Drawing.Size(99, 16);
            this.label_number.TabIndex = 8;
            this.label_number.Text = "Phone Number:";
            // 
            // textedit_number
            // 
            this.textedit_number.Location = new System.Drawing.Point(170, 261);
            this.textedit_number.Name = "textedit_number";
            this.textedit_number.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textedit_number.Properties.Appearance.Options.UseFont = true;
            this.textedit_number.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.textedit_number.Size = new System.Drawing.Size(290, 24);
            this.textedit_number.TabIndex = 9;
            // 
            // button_update
            // 
            this.button_update.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button_update.Appearance.Options.UseFont = true;
            this.button_update.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.button_update.Location = new System.Drawing.Point(170, 315);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(290, 45);
            this.button_update.TabIndex = 10;
            this.button_update.Text = "Update Customer Profile";
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // UpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 410);
            this.Controls.Add(this.groupControl_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "UpdateCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Customer Information";
            this.Load += new System.EventHandler(this.UpdateCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_main)).EndInit();
            this.groupControl_main.ResumeLayout(false);
            this.groupControl_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textedit_first_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textedit_last_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textedit_email.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textedit_number.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl_main;
        private DevExpress.XtraEditors.LabelControl label_customer;
        private System.Windows.Forms.ComboBox combobox_customer;
        private DevExpress.XtraEditors.LabelControl label_first_name;
        private DevExpress.XtraEditors.TextEdit textedit_first_name;
        private DevExpress.XtraEditors.LabelControl label_last_name;
        private DevExpress.XtraEditors.TextEdit textedit_last_name;
        private DevExpress.XtraEditors.LabelControl label_email;
        private DevExpress.XtraEditors.TextEdit textedit_email;
        private DevExpress.XtraEditors.LabelControl label_number;
        private DevExpress.XtraEditors.TextEdit textedit_number;
        private DevExpress.XtraEditors.SimpleButton button_update;
    }
}