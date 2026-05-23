namespace QubixCinema.Forms.MovieForms
{
    partial class UpdateMovie
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
            this.button_update = new System.Windows.Forms.Button();
            this.label_release_date = new DevExpress.XtraEditors.LabelControl();
            this.label_runtime = new DevExpress.XtraEditors.LabelControl();
            this.textedit_genre = new DevExpress.XtraEditors.TextEdit();
            this.label_genre = new DevExpress.XtraEditors.LabelControl();
            this.textedit_movie_name = new DevExpress.XtraEditors.TextEdit();
            this.label_movie_name = new DevExpress.XtraEditors.LabelControl();
            this.label_movie = new DevExpress.XtraEditors.LabelControl();
            this.dateedit_release_date = new DevExpress.XtraEditors.DateEdit();
            this.numeric_runtime = new System.Windows.Forms.NumericUpDown();
            this.combobox_movie = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.textedit_genre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textedit_movie_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateedit_release_date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateedit_release_date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_runtime)).BeginInit();
            this.SuspendLayout();
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
            this.button_update.TabIndex = 17;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // label_release_date
            // 
            this.label_release_date.Appearance.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_release_date.Appearance.Options.UseFont = true;
            this.label_release_date.Location = new System.Drawing.Point(226, 387);
            this.label_release_date.Name = "label_release_date";
            this.label_release_date.Size = new System.Drawing.Size(244, 45);
            this.label_release_date.TabIndex = 15;
            this.label_release_date.Text = "Release Date";
            // 
            // label_runtime
            // 
            this.label_runtime.Appearance.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_runtime.Appearance.Options.UseFont = true;
            this.label_runtime.Location = new System.Drawing.Point(315, 296);
            this.label_runtime.Name = "label_runtime";
            this.label_runtime.Size = new System.Drawing.Size(155, 45);
            this.label_runtime.TabIndex = 13;
            this.label_runtime.Text = "Runtime";
            // 
            // textedit_genre
            // 
            this.textedit_genre.Location = new System.Drawing.Point(486, 216);
            this.textedit_genre.Name = "textedit_genre";
            this.textedit_genre.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textedit_genre.Properties.Appearance.Options.UseFont = true;
            this.textedit_genre.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textedit_genre.Size = new System.Drawing.Size(475, 34);
            this.textedit_genre.TabIndex = 12;
            // 
            // label_genre
            // 
            this.label_genre.Appearance.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_genre.Appearance.Options.UseFont = true;
            this.label_genre.Location = new System.Drawing.Point(352, 205);
            this.label_genre.Name = "label_genre";
            this.label_genre.Size = new System.Drawing.Size(112, 45);
            this.label_genre.TabIndex = 11;
            this.label_genre.Text = "Genre";
            // 
            // textedit_movie_name
            // 
            this.textedit_movie_name.Location = new System.Drawing.Point(486, 125);
            this.textedit_movie_name.Name = "textedit_movie_name";
            this.textedit_movie_name.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textedit_movie_name.Properties.Appearance.Options.UseFont = true;
            this.textedit_movie_name.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textedit_movie_name.Size = new System.Drawing.Size(475, 34);
            this.textedit_movie_name.TabIndex = 10;
            // 
            // label_movie_name
            // 
            this.label_movie_name.Appearance.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_movie_name.Appearance.Options.UseFont = true;
            this.label_movie_name.Location = new System.Drawing.Point(236, 114);
            this.label_movie_name.Name = "label_movie_name";
            this.label_movie_name.Size = new System.Drawing.Size(228, 45);
            this.label_movie_name.TabIndex = 9;
            this.label_movie_name.Text = "Movie Name";
            // 
            // label_movie
            // 
            this.label_movie.Appearance.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_movie.Appearance.Options.UseFont = true;
            this.label_movie.Location = new System.Drawing.Point(236, 23);
            this.label_movie.Name = "label_movie";
            this.label_movie.Size = new System.Drawing.Size(233, 45);
            this.label_movie.TabIndex = 19;
            this.label_movie.Text = "Select Movie";
            // 
            // dateedit_release_date
            // 
            this.dateedit_release_date.EditValue = null;
            this.dateedit_release_date.Location = new System.Drawing.Point(486, 305);
            this.dateedit_release_date.Name = "dateedit_release_date";
            this.dateedit_release_date.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateedit_release_date.Properties.Appearance.Options.UseFont = true;
            this.dateedit_release_date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateedit_release_date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateedit_release_date.Size = new System.Drawing.Size(475, 36);
            this.dateedit_release_date.TabIndex = 21;
            // 
            // numeric_runtime
            // 
            this.numeric_runtime.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numeric_runtime.Location = new System.Drawing.Point(486, 395);
            this.numeric_runtime.Name = "numeric_runtime";
            this.numeric_runtime.Size = new System.Drawing.Size(303, 37);
            this.numeric_runtime.TabIndex = 20;
            // 
            // combobox_movie
            // 
            this.combobox_movie.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.combobox_movie.FormattingEnabled = true;
            this.combobox_movie.Location = new System.Drawing.Point(486, 31);
            this.combobox_movie.Name = "combobox_movie";
            this.combobox_movie.Size = new System.Drawing.Size(475, 37);
            this.combobox_movie.TabIndex = 22;
            this.combobox_movie.SelectedIndexChanged += new System.EventHandler(this.combobox_movie_SelectedIndexChanged);
            // 
            // UpdateMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1050, 450);
            this.Controls.Add(this.combobox_movie);
            this.Controls.Add(this.dateedit_release_date);
            this.Controls.Add(this.numeric_runtime);
            this.Controls.Add(this.label_movie);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.label_release_date);
            this.Controls.Add(this.label_runtime);
            this.Controls.Add(this.textedit_genre);
            this.Controls.Add(this.label_genre);
            this.Controls.Add(this.textedit_movie_name);
            this.Controls.Add(this.label_movie_name);
            this.Name = "UpdateMovie";
            this.Text = " ";
            this.Load += new System.EventHandler(this.UpdateMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textedit_genre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textedit_movie_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateedit_release_date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateedit_release_date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_runtime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_update;
        private DevExpress.XtraEditors.LabelControl label_release_date;
        private DevExpress.XtraEditors.LabelControl label_runtime;
        private DevExpress.XtraEditors.TextEdit textedit_genre;
        private DevExpress.XtraEditors.LabelControl label_genre;
        private DevExpress.XtraEditors.TextEdit textedit_movie_name;
        private DevExpress.XtraEditors.LabelControl label_movie_name;
        private DevExpress.XtraEditors.LabelControl label_movie;
        private DevExpress.XtraEditors.DateEdit dateedit_release_date;
        private System.Windows.Forms.NumericUpDown numeric_runtime;
        private System.Windows.Forms.ComboBox combobox_movie;
    }
}