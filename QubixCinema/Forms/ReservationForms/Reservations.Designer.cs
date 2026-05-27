namespace QubixCinema.Forms.ReservationForms
{
    partial class Reservations
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
            this.groupControl_seats = new DevExpress.XtraEditors.GroupControl();
            this.flowLayout_seats = new System.Windows.Forms.FlowLayoutPanel();
            this.groupControl_actions = new DevExpress.XtraEditors.GroupControl();
            this.labelControl_movie = new DevExpress.XtraEditors.LabelControl();
            this.combobox_movie = new System.Windows.Forms.ComboBox();
            this.labelControl_customer = new DevExpress.XtraEditors.LabelControl();
            this.combobox_customer = new System.Windows.Forms.ComboBox();
            this.labelControl_seat_info = new DevExpress.XtraEditors.LabelControl();
            this.label_selected_seat = new DevExpress.XtraEditors.LabelControl();
            this.labelControl_status_title = new DevExpress.XtraEditors.LabelControl();
            this.label_seat_status = new DevExpress.XtraEditors.LabelControl();
            this.label_reservation_details = new DevExpress.XtraEditors.LabelControl();
            this.btn_book_seat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_cancel_reservation = new DevExpress.XtraEditors.SimpleButton();
            this.combobox_hall = new System.Windows.Forms.ComboBox();
            this.labelControl_hall = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_seats)).BeginInit();
            this.groupControl_seats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_actions)).BeginInit();
            this.groupControl_actions.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl_seats
            // 
            this.groupControl_seats.Controls.Add(this.flowLayout_seats);
            this.groupControl_seats.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl_seats.Location = new System.Drawing.Point(0, 0);
            this.groupControl_seats.Name = "groupControl_seats";
            this.groupControl_seats.Size = new System.Drawing.Size(1012, 280);
            this.groupControl_seats.TabIndex = 0;
            this.groupControl_seats.Text = "Cinema Hall Seats Visualizer";
            // 
            // flowLayout_seats
            // 
            this.flowLayout_seats.AutoScroll = true;
            this.flowLayout_seats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayout_seats.Location = new System.Drawing.Point(2, 23);
            this.flowLayout_seats.Name = "flowLayout_seats";
            this.flowLayout_seats.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayout_seats.Size = new System.Drawing.Size(1008, 255);
            this.flowLayout_seats.TabIndex = 0;
            // 
            // groupControl_actions
            // 
            this.groupControl_actions.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.groupControl_actions.AppearanceCaption.Options.UseFont = true;
            this.groupControl_actions.Controls.Add(this.combobox_hall);
            this.groupControl_actions.Controls.Add(this.labelControl_hall);
            this.groupControl_actions.Controls.Add(this.btn_cancel_reservation);
            this.groupControl_actions.Controls.Add(this.btn_book_seat);
            this.groupControl_actions.Controls.Add(this.label_reservation_details);
            this.groupControl_actions.Controls.Add(this.label_seat_status);
            this.groupControl_actions.Controls.Add(this.labelControl_status_title);
            this.groupControl_actions.Controls.Add(this.label_selected_seat);
            this.groupControl_actions.Controls.Add(this.labelControl_seat_info);
            this.groupControl_actions.Controls.Add(this.combobox_customer);
            this.groupControl_actions.Controls.Add(this.labelControl_customer);
            this.groupControl_actions.Controls.Add(this.combobox_movie);
            this.groupControl_actions.Controls.Add(this.labelControl_movie);
            this.groupControl_actions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl_actions.Location = new System.Drawing.Point(0, 280);
            this.groupControl_actions.Name = "groupControl_actions";
            this.groupControl_actions.Size = new System.Drawing.Size(1012, 292);
            this.groupControl_actions.TabIndex = 1;
            this.groupControl_actions.Text = "Booking & Reservation Control Panel ($ USD)";
            // 
            // labelControl_movie
            // 
            this.labelControl_movie.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.labelControl_movie.Appearance.Options.UseFont = true;
            this.labelControl_movie.Location = new System.Drawing.Point(30, 50);
            this.labelControl_movie.Name = "labelControl_movie";
            this.labelControl_movie.Size = new System.Drawing.Size(90, 16);
            this.labelControl_movie.TabIndex = 0;
            this.labelControl_movie.Text = "Select Movie:";
            // 
            // combobox_movie
            // 
            this.combobox_movie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_movie.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.combobox_movie.FormattingEnabled = true;
            this.combobox_movie.Location = new System.Drawing.Point(140, 46);
            this.combobox_movie.Name = "combobox_movie";
            this.combobox_movie.Size = new System.Drawing.Size(320, 24);
            this.combobox_movie.TabIndex = 1;
            // 
            // labelControl_customer
            // 
            this.labelControl_customer.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.labelControl_customer.Appearance.Options.UseFont = true;
            this.labelControl_customer.Location = new System.Drawing.Point(30, 95);
            this.labelControl_customer.Name = "labelControl_customer";
            this.labelControl_customer.Size = new System.Drawing.Size(112, 16);
            this.labelControl_customer.TabIndex = 2;
            this.labelControl_customer.Text = "Select Customer:";
            // 
            // combobox_customer
            // 
            this.combobox_customer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_customer.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.combobox_customer.FormattingEnabled = true;
            this.combobox_customer.Location = new System.Drawing.Point(140, 91);
            this.combobox_customer.Name = "combobox_customer";
            this.combobox_customer.Size = new System.Drawing.Size(320, 24);
            this.combobox_customer.TabIndex = 3;
            // 
            // labelControl_hall
            // 
            this.labelControl_hall.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.labelControl_hall.Appearance.Options.UseFont = true;
            this.labelControl_hall.Location = new System.Drawing.Point(30, 140);
            this.labelControl_hall.Name = "labelControl_hall";
            this.labelControl_hall.Size = new System.Drawing.Size(76, 16);
            this.labelControl_hall.TabIndex = 11;
            this.labelControl_hall.Text = "Select Hall:";
            // 
            // combobox_hall
            // 
            this.combobox_hall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_hall.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.combobox_hall.FormattingEnabled = true;
            this.combobox_hall.Location = new System.Drawing.Point(140, 136);
            this.combobox_hall.Name = "combobox_hall";
            this.combobox_hall.Size = new System.Drawing.Size(320, 24);
            this.combobox_hall.TabIndex = 12;
            this.combobox_hall.SelectedIndexChanged += new System.EventHandler(this.combobox_hall_SelectedIndexChanged);
            // 
            // labelControl_seat_info
            // 
            this.labelControl_seat_info.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.labelControl_seat_info.Appearance.Options.UseFont = true;
            this.labelControl_seat_info.Location = new System.Drawing.Point(540, 50);
            this.labelControl_seat_info.Name = "labelControl_seat_info";
            this.labelControl_seat_info.Size = new System.Drawing.Size(95, 16);
            this.labelControl_seat_info.TabIndex = 4;
            this.labelControl_seat_info.Text = "Selected Seat:";
            // 
            // label_selected_seat
            // 
            this.label_selected_seat.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label_selected_seat.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_selected_seat.Appearance.Options.UseFont = true;
            this.label_selected_seat.Appearance.Options.UseForeColor = true;
            this.label_selected_seat.Location = new System.Drawing.Point(660, 48);
            this.label_selected_seat.Name = "label_selected_seat";
            this.label_selected_seat.Size = new System.Drawing.Size(96, 18);
            this.label_selected_seat.TabIndex = 5;
            this.label_selected_seat.Text = "None Selected";
            // 
            // labelControl_status_title
            // 
            this.labelControl_status_title.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.labelControl_status_title.Appearance.Options.UseFont = true;
            this.labelControl_status_title.Location = new System.Drawing.Point(540, 95);
            this.labelControl_status_title.Name = "labelControl_status_title";
            this.labelControl_status_title.Size = new System.Drawing.Size(81, 16);
            this.labelControl_status_title.TabIndex = 6;
            this.labelControl_status_title.Text = "Seat Status:";
            // 
            // label_seat_status
            // 
            this.label_seat_status.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label_seat_status.Appearance.Options.UseFont = true;
            this.label_seat_status.Location = new System.Drawing.Point(660, 95);
            this.label_seat_status.Name = "label_seat_status";
            this.label_seat_status.Size = new System.Drawing.Size(7, 16);
            this.label_seat_status.TabIndex = 7;
            this.label_seat_status.Text = "-";
            // 
            // label_reservation_details
            // 
            this.label_reservation_details.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Italic);
            this.label_reservation_details.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.label_reservation_details.Appearance.Options.UseFont = true;
            this.label_reservation_details.Appearance.Options.UseForeColor = true;
            this.label_reservation_details.Location = new System.Drawing.Point(540, 140);
            this.label_reservation_details.Name = "label_reservation_details";
            this.label_reservation_details.Size = new System.Drawing.Size(5, 16);
            this.label_reservation_details.TabIndex = 8;
            this.label_reservation_details.Text = " ";
            // 
            // btn_book_seat
            // 
            this.btn_book_seat.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_book_seat.Appearance.Options.UseFont = true;
            this.btn_book_seat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_book_seat.Enabled = false;
            this.btn_book_seat.Location = new System.Drawing.Point(30, 190);
            this.btn_book_seat.Name = "btn_book_seat";
            this.btn_book_seat.Size = new System.Drawing.Size(430, 45);
            this.btn_book_seat.TabIndex = 9;
            this.btn_book_seat.Text = "Book Seat ($15.00)";
            this.btn_book_seat.Click += new System.EventHandler(this.btn_book_seat_Click);
            // 
            // btn_cancel_reservation
            // 
            this.btn_cancel_reservation.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_cancel_reservation.Appearance.Options.UseFont = true;
            this.btn_cancel_reservation.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_cancel_reservation.Location = new System.Drawing.Point(540, 190);
            this.btn_cancel_reservation.Name = "btn_cancel_reservation";
            this.btn_cancel_reservation.Size = new System.Drawing.Size(430, 45);
            this.btn_cancel_reservation.TabIndex = 10;
            this.btn_cancel_reservation.Text = "Cancel Selected Reservation";
            this.btn_cancel_reservation.Visible = false;
            this.btn_cancel_reservation.Click += new System.EventHandler(this.btn_cancel_reservation_Click);
            // 
            // Reservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 572);
            this.Controls.Add(this.groupControl_actions);
            this.Controls.Add(this.groupControl_seats);
            this.Name = "Reservations";
            this.Text = "Cinema Seat Reservations Control Panel";
            this.Load += new System.EventHandler(this.Reservations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_seats)).EndInit();
            this.groupControl_seats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_actions)).EndInit();
            this.groupControl_actions.ResumeLayout(false);
            this.groupControl_actions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl_seats;
        private System.Windows.Forms.FlowLayoutPanel flowLayout_seats;
        private DevExpress.XtraEditors.GroupControl groupControl_actions;
        private DevExpress.XtraEditors.LabelControl labelControl_movie;
        private System.Windows.Forms.ComboBox combobox_movie;
        private DevExpress.XtraEditors.LabelControl labelControl_customer;
        private System.Windows.Forms.ComboBox combobox_customer;
        private DevExpress.XtraEditors.LabelControl labelControl_seat_info;
        private DevExpress.XtraEditors.LabelControl label_selected_seat;
        private DevExpress.XtraEditors.LabelControl labelControl_status_title;
        private DevExpress.XtraEditors.LabelControl label_seat_status;
        private DevExpress.XtraEditors.LabelControl label_reservation_details;
        private DevExpress.XtraEditors.SimpleButton btn_book_seat;
        private DevExpress.XtraEditors.SimpleButton btn_cancel_reservation;
        private System.Windows.Forms.ComboBox combobox_hall;
        private DevExpress.XtraEditors.LabelControl labelControl_hall;
    }
}