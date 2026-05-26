namespace QubixCinema.Forms.CustomerForms
{
    partial class DeleteCustomer
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
            this.grid_customers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_customers)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_customers
            // 
            this.grid_customers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_customers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_customers.Location = new System.Drawing.Point(0, 0);
            this.grid_customers.Name = "grid_customers";
            this.grid_customers.ReadOnly = true;
            this.grid_customers.Size = new System.Drawing.Size(1050, 450);
            this.grid_customers.TabIndex = 1;
            this.grid_customers.DoubleClick += new System.EventHandler(this.grid_customers_DoubleClick);
            // 
            // DeleteCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 450);
            this.Controls.Add(this.grid_customers);
            this.Name = "DeleteCustomer";
            this.Text = "DeleteCustomer";
            this.Load += new System.EventHandler(this.DeleteCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_customers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_customers;
    }
}