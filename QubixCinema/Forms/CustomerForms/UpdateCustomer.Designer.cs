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
            this.label_customer = new DevExpress.XtraEditors.LabelControl();
            this.button_update = new System.Windows.Forms.Button();
            this.label_number = new DevExpress.XtraEditors.LabelControl();
            this.label_email = new DevExpress.XtraEditors.LabelControl();
            this.textedit_last_name = new DevExpress.XtraEditors.TextEdit();
            this.label_last_name = new DevExpress.XtraEditors.LabelControl();
            this.textedit_first_name = new DevExpress.XtraEditors.TextEdit();
            this.label_first_name = new DevExpress.XtraEditors.LabelControl();
            this.combobox_customer = new System.Windows.Forms.ComboBox();
            this.textedit_email = new DevExpress.XtraEditors.TextEdit();
            this.textedit_number = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textedit_last_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textedit_first_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textedit_email.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textedit_number.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label_customer
            // 
            this.label_customer.Appearance.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_customer.Appearance.Options.UseFont = true;
            this.label_customer.Location = new System.Drawing.Point(161, 23);
            this.label_customer.Name = "label_customer";
            this.label_customer.Size = new System.Drawing.Size(306, 45);
            this.label_customer.TabIndex = 30;
            this.label_customer.Text = "Select Customer";
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.White;
            this.button_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_update.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_update.FlatAppearance.BorderSize = 0;
            this.button_update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_update.Location = new System.Drawing.Point(827, 369);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(134, 63);
            this.button_update.TabIndex = 29;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // label_number
            // 
            this.label_number.Appearance.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_number.Appearance.Options.UseFont = true;
            this.label_number.Location = new System.Drawing.Point(193, 386);
            this.label_number.Name = "label_number";
            this.label_number.Size = new System.Drawing.Size(274, 45);
            this.label_number.TabIndex = 28;
            this.label_number.Text = "Phone Number";
            // 
            // label_email
            // 
            this.label_email.Appearance.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_email.Appearance.Options.UseFont = true;
            this.label_email.Location = new System.Drawing.Point(312, 297);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(155, 45);
            this.label_email.TabIndex = 27;
            this.label_email.Text = "Runtime";
            // 
            // textedit_last_name
            // 
            this.textedit_last_name.Location = new System.Drawing.Point(486, 216);
            this.textedit_last_name.Name = "textedit_last_name";
            this.textedit_last_name.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textedit_last_name.Properties.Appearance.Options.UseFont = true;
            this.textedit_last_name.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textedit_last_name.Size = new System.Drawing.Size(475, 34);
            this.textedit_last_name.TabIndex = 26;
            // 
            // label_last_name
            // 
            this.label_last_name.Appearance.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_last_name.Appearance.Options.UseFont = true;
            this.label_last_name.Location = new System.Drawing.Point(269, 205);
            this.label_last_name.Name = "label_last_name";
            this.label_last_name.Size = new System.Drawing.Size(198, 45);
            this.label_last_name.TabIndex = 25;
            this.label_last_name.Text = "Last Name";
            // 
            // textedit_first_name
            // 
            this.textedit_first_name.Location = new System.Drawing.Point(486, 125);
            this.textedit_first_name.Name = "textedit_first_name";
            this.textedit_first_name.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textedit_first_name.Properties.Appearance.Options.UseFont = true;
            this.textedit_first_name.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textedit_first_name.Size = new System.Drawing.Size(475, 34);
            this.textedit_first_name.TabIndex = 24;
            // 
            // label_first_name
            // 
            this.label_first_name.Appearance.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_first_name.Appearance.Options.UseFont = true;
            this.label_first_name.Location = new System.Drawing.Point(265, 114);
            this.label_first_name.Name = "label_first_name";
            this.label_first_name.Size = new System.Drawing.Size(202, 45);
            this.label_first_name.TabIndex = 23;
            this.label_first_name.Text = "First Name";
            // 
            // combobox_customer
            // 
            this.combobox_customer.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.combobox_customer.FormattingEnabled = true;
            this.combobox_customer.Location = new System.Drawing.Point(486, 31);
            this.combobox_customer.Name = "combobox_customer";
            this.combobox_customer.Size = new System.Drawing.Size(475, 37);
            this.combobox_customer.TabIndex = 33;
            this.combobox_customer.SelectedIndexChanged += new System.EventHandler(this.combobox_customer_SelectedIndexChanged);
            // 
            // textedit_email
            // 
            this.textedit_email.Location = new System.Drawing.Point(486, 308);
            this.textedit_email.Name = "textedit_email";
            this.textedit_email.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textedit_email.Properties.Appearance.Options.UseFont = true;
            this.textedit_email.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textedit_email.Size = new System.Drawing.Size(475, 34);
            this.textedit_email.TabIndex = 34;
            // 
            // textedit_number
            // 
            this.textedit_number.Location = new System.Drawing.Point(486, 398);
            this.textedit_number.Name = "textedit_number";
            this.textedit_number.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textedit_number.Properties.Appearance.Options.UseFont = true;
            this.textedit_number.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textedit_number.Size = new System.Drawing.Size(291, 34);
            this.textedit_number.TabIndex = 35;
            // 
            // UpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 450);
            this.Controls.Add(this.textedit_number);
            this.Controls.Add(this.textedit_email);
            this.Controls.Add(this.combobox_customer);
            this.Controls.Add(this.label_customer);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.label_number);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.textedit_last_name);
            this.Controls.Add(this.label_last_name);
            this.Controls.Add(this.textedit_first_name);
            this.Controls.Add(this.label_first_name);
            this.Name = "UpdateCustomer";
            this.Text = "Email";
            this.Load += new System.EventHandler(this.UpdateCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textedit_last_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textedit_first_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textedit_email.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textedit_number.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl label_customer;
        private System.Windows.Forms.Button button_update;
        private DevExpress.XtraEditors.LabelControl label_number;
        private DevExpress.XtraEditors.LabelControl label_email;
        private DevExpress.XtraEditors.TextEdit textedit_last_name;
        private DevExpress.XtraEditors.LabelControl label_last_name;
        private DevExpress.XtraEditors.TextEdit textedit_first_name;
        private DevExpress.XtraEditors.LabelControl label_first_name;
        private System.Windows.Forms.ComboBox combobox_customer;
        private DevExpress.XtraEditors.TextEdit textedit_email;
        private DevExpress.XtraEditors.TextEdit textedit_number;
    }
}