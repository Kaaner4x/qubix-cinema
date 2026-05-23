namespace QubixCinema.Forms.MovieForms
{
    partial class AddMovie
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
            this.label_movie_name = new DevExpress.XtraEditors.LabelControl();
            this.textedit_movie_name = new DevExpress.XtraEditors.TextEdit();
            this.textedit_genre = new DevExpress.XtraEditors.TextEdit();
            this.label_genre = new DevExpress.XtraEditors.LabelControl();
            this.label_runtime = new DevExpress.XtraEditors.LabelControl();
            this.label_release_date = new DevExpress.XtraEditors.LabelControl();
            this.button_add = new System.Windows.Forms.Button();
            this.numeric_runtime = new System.Windows.Forms.NumericUpDown();
            this.dateedit_release_date = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textedit_movie_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textedit_genre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_runtime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateedit_release_date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateedit_release_date.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // label_movie_name
            // 
            this.label_movie_name.Appearance.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_movie_name.Appearance.Options.UseFont = true;
            this.label_movie_name.Location = new System.Drawing.Point(237, 49);
            this.label_movie_name.Name = "label_movie_name";
            this.label_movie_name.Size = new System.Drawing.Size(228, 45);
            this.label_movie_name.TabIndex = 0;
            this.label_movie_name.Text = "Movie Name";
            // 
            // textedit_movie_name
            // 
            this.textedit_movie_name.Location = new System.Drawing.Point(486, 60);
            this.textedit_movie_name.Name = "textedit_movie_name";
            this.textedit_movie_name.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textedit_movie_name.Properties.Appearance.Options.UseFont = true;
            this.textedit_movie_name.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textedit_movie_name.Size = new System.Drawing.Size(475, 34);
            this.textedit_movie_name.TabIndex = 1;
            // 
            // textedit_genre
            // 
            this.textedit_genre.Location = new System.Drawing.Point(486, 166);
            this.textedit_genre.Name = "textedit_genre";
            this.textedit_genre.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textedit_genre.Properties.Appearance.Options.UseFont = true;
            this.textedit_genre.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textedit_genre.Size = new System.Drawing.Size(475, 34);
            this.textedit_genre.TabIndex = 3;
            // 
            // label_genre
            // 
            this.label_genre.Appearance.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_genre.Appearance.Options.UseFont = true;
            this.label_genre.Location = new System.Drawing.Point(353, 155);
            this.label_genre.Name = "label_genre";
            this.label_genre.Size = new System.Drawing.Size(112, 45);
            this.label_genre.TabIndex = 2;
            this.label_genre.Text = "Genre";
            // 
            // label_runtime
            // 
            this.label_runtime.Appearance.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_runtime.Appearance.Options.UseFont = true;
            this.label_runtime.Location = new System.Drawing.Point(310, 367);
            this.label_runtime.Name = "label_runtime";
            this.label_runtime.Size = new System.Drawing.Size(155, 45);
            this.label_runtime.TabIndex = 4;
            this.label_runtime.Text = "Runtime";
            // 
            // label_release_date
            // 
            this.label_release_date.Appearance.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_release_date.Appearance.Options.UseFont = true;
            this.label_release_date.Location = new System.Drawing.Point(221, 261);
            this.label_release_date.Name = "label_release_date";
            this.label_release_date.Size = new System.Drawing.Size(244, 45);
            this.label_release_date.TabIndex = 6;
            this.label_release_date.Text = "Release Date";
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.White;
            this.button_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_add.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_add.FlatAppearance.BorderSize = 0;
            this.button_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_add.Location = new System.Drawing.Point(827, 349);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(134, 63);
            this.button_add.TabIndex = 8;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // numeric_runtime
            // 
            this.numeric_runtime.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numeric_runtime.Location = new System.Drawing.Point(486, 375);
            this.numeric_runtime.Name = "numeric_runtime";
            this.numeric_runtime.Size = new System.Drawing.Size(303, 37);
            this.numeric_runtime.TabIndex = 9;
            // 
            // dateedit_release_date
            // 
            this.dateedit_release_date.EditValue = null;
            this.dateedit_release_date.Location = new System.Drawing.Point(486, 270);
            this.dateedit_release_date.Name = "dateedit_release_date";
            this.dateedit_release_date.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateedit_release_date.Properties.Appearance.Options.UseFont = true;
            this.dateedit_release_date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateedit_release_date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateedit_release_date.Size = new System.Drawing.Size(475, 36);
            this.dateedit_release_date.TabIndex = 10;
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1050, 450);
            this.Controls.Add(this.dateedit_release_date);
            this.Controls.Add(this.numeric_runtime);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label_release_date);
            this.Controls.Add(this.label_runtime);
            this.Controls.Add(this.textedit_genre);
            this.Controls.Add(this.label_genre);
            this.Controls.Add(this.textedit_movie_name);
            this.Controls.Add(this.label_movie_name);
            this.Name = "AddMovie";
            this.Opacity = 0.5D;
            this.Text = "Add a new movie";
            ((System.ComponentModel.ISupportInitialize)(this.textedit_movie_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textedit_genre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_runtime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateedit_release_date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateedit_release_date.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl label_movie_name;
        private DevExpress.XtraEditors.TextEdit textedit_movie_name;
        private DevExpress.XtraEditors.TextEdit textedit_genre;
        private DevExpress.XtraEditors.LabelControl label_genre;
        private DevExpress.XtraEditors.LabelControl label_runtime;
        private DevExpress.XtraEditors.LabelControl label_release_date;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.NumericUpDown numeric_runtime;
        private DevExpress.XtraEditors.DateEdit dateedit_release_date;
    }
}