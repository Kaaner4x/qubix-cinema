namespace QubixCinema.Forms.ReservationForms
{
    partial class Seats
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
            this.groupControl_top = new DevExpress.XtraEditors.GroupControl();
            this.labelControl_hall = new DevExpress.XtraEditors.LabelControl();
            this.combobox_hall = new System.Windows.Forms.ComboBox();
            this.lbl_total_seats = new DevExpress.XtraEditors.LabelControl();
            this.lbl_available_seats = new DevExpress.XtraEditors.LabelControl();
            this.lbl_booked_seats = new DevExpress.XtraEditors.LabelControl();
            this.flowLayout_seats = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_top)).BeginInit();
            this.groupControl_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl_top
            // 
            this.groupControl_top.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.groupControl_top.AppearanceCaption.Options.UseFont = true;
            this.groupControl_top.Controls.Add(this.lbl_booked_seats);
            this.groupControl_top.Controls.Add(this.lbl_available_seats);
            this.groupControl_top.Controls.Add(this.lbl_total_seats);
            this.groupControl_top.Controls.Add(this.combobox_hall);
            this.groupControl_top.Controls.Add(this.labelControl_hall);
            this.groupControl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl_top.Location = new System.Drawing.Point(0, 0);
            this.groupControl_top.Name = "groupControl_top";
            this.groupControl_top.Size = new System.Drawing.Size(900, 95);
            this.groupControl_top.TabIndex = 0;
            this.groupControl_top.Text = "Cinema Hall Status & Visual Seat Map";
            // 
            // labelControl_hall
            // 
            this.labelControl_hall.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.labelControl_hall.Appearance.Options.UseFont = true;
            this.labelControl_hall.Location = new System.Drawing.Point(30, 48);
            this.labelControl_hall.Name = "labelControl_hall";
            this.labelControl_hall.Size = new System.Drawing.Size(76, 16);
            this.labelControl_hall.TabIndex = 0;
            this.labelControl_hall.Text = "Select Hall:";
            // 
            // combobox_hall
            // 
            this.combobox_hall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_hall.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.combobox_hall.FormattingEnabled = true;
            this.combobox_hall.Location = new System.Drawing.Point(120, 44);
            this.combobox_hall.Name = "combobox_hall";
            this.combobox_hall.Size = new System.Drawing.Size(180, 24);
            this.combobox_hall.TabIndex = 1;
            this.combobox_hall.SelectedIndexChanged += new System.EventHandler(this.combobox_hall_SelectedIndexChanged);
            // 
            // lbl_total_seats
            // 
            this.lbl_total_seats.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.lbl_total_seats.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_total_seats.Appearance.Options.UseFont = true;
            this.lbl_total_seats.Appearance.Options.UseForeColor = true;
            this.lbl_total_seats.Location = new System.Drawing.Point(350, 48);
            this.lbl_total_seats.Name = "lbl_total_seats";
            this.lbl_total_seats.Size = new System.Drawing.Size(100, 16);
            this.lbl_total_seats.TabIndex = 2;
            this.lbl_total_seats.Text = "Total Seats: 50";
            // 
            // lbl_available_seats
            // 
            this.lbl_available_seats.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.lbl_available_seats.Appearance.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_available_seats.Appearance.Options.UseFont = true;
            this.lbl_available_seats.Appearance.Options.UseForeColor = true;
            this.lbl_available_seats.Location = new System.Drawing.Point(520, 48);
            this.lbl_available_seats.Name = "lbl_available_seats";
            this.lbl_available_seats.Size = new System.Drawing.Size(95, 16);
            this.lbl_available_seats.TabIndex = 3;
            this.lbl_available_seats.Text = "Available: 50";
            // 
            // lbl_booked_seats
            // 
            this.lbl_booked_seats.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.lbl_booked_seats.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_booked_seats.Appearance.Options.UseFont = true;
            this.lbl_booked_seats.Appearance.Options.UseForeColor = true;
            this.lbl_booked_seats.Location = new System.Drawing.Point(680, 48);
            this.lbl_booked_seats.Name = "lbl_booked_seats";
            this.lbl_booked_seats.Size = new System.Drawing.Size(71, 16);
            this.lbl_booked_seats.TabIndex = 4;
            this.lbl_booked_seats.Text = "Booked: 0";
            // 
            // flowLayout_seats
            // 
            this.flowLayout_seats.AutoScroll = true;
            this.flowLayout_seats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayout_seats.Location = new System.Drawing.Point(0, 95);
            this.flowLayout_seats.Name = "flowLayout_seats";
            this.flowLayout_seats.Padding = new System.Windows.Forms.Padding(15);
            this.flowLayout_seats.Size = new System.Drawing.Size(900, 405);
            this.flowLayout_seats.TabIndex = 1;
            // 
            // Seats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.flowLayout_seats);
            this.Controls.Add(this.groupControl_top);
            this.Name = "Seats";
            this.Text = "Cinema Hall Seats Monitor";
            this.Load += new System.EventHandler(this.Seats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_top)).EndInit();
            this.groupControl_top.ResumeLayout(false);
            this.groupControl_top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl_top;
        private System.Windows.Forms.ComboBox combobox_hall;
        private DevExpress.XtraEditors.LabelControl labelControl_hall;
        private DevExpress.XtraEditors.LabelControl lbl_booked_seats;
        private DevExpress.XtraEditors.LabelControl lbl_available_seats;
        private DevExpress.XtraEditors.LabelControl lbl_total_seats;
        private System.Windows.Forms.FlowLayoutPanel flowLayout_seats;
    }
}