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
            this.groupControl_main = new DevExpress.XtraEditors.GroupControl();
            this.label_movie_name = new DevExpress.XtraEditors.LabelControl();
            this.textedit_movie_name = new DevExpress.XtraEditors.TextEdit();
            this.label_genre = new DevExpress.XtraEditors.LabelControl();
            this.textedit_genre = new DevExpress.XtraEditors.TextEdit();
            this.label_release_date = new DevExpress.XtraEditors.LabelControl();
            this.dateedit_release_date = new DevExpress.XtraEditors.DateEdit();
            this.label_runtime = new DevExpress.XtraEditors.LabelControl();
            this.numeric_runtime = new System.Windows.Forms.NumericUpDown();
            this.button_add = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_main)).BeginInit();
            this.groupControl_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textedit_movie_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textedit_genre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateedit_release_date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateedit_release_date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_runtime)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl_main
            // 
            this.groupControl_main.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.groupControl_main.AppearanceCaption.Options.UseFont = true;
            this.groupControl_main.Controls.Add(this.button_add);
            this.groupControl_main.Controls.Add(this.numeric_runtime);
            this.groupControl_main.Controls.Add(this.label_runtime);
            this.groupControl_main.Controls.Add(this.dateedit_release_date);
            this.groupControl_main.Controls.Add(this.label_release_date);
            this.groupControl_main.Controls.Add(this.textedit_genre);
            this.groupControl_main.Controls.Add(this.label_genre);
            this.groupControl_main.Controls.Add(this.textedit_movie_name);
            this.groupControl_main.Controls.Add(this.label_movie_name);
            this.groupControl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl_main.Location = new System.Drawing.Point(0, 0);
            this.groupControl_main.Name = "groupControl_main";
            this.groupControl_main.Size = new System.Drawing.Size(520, 360);
            this.groupControl_main.TabIndex = 0;
            this.groupControl_main.Text = "Register New Movie Profile";
            // 
            // label_movie_name
            // 
            this.label_movie_name.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.label_movie_name.Appearance.Options.UseFont = true;
            this.label_movie_name.Location = new System.Drawing.Point(40, 60);
            this.label_movie_name.Name = "label_movie_name";
            this.label_movie_name.Size = new System.Drawing.Size(82, 16);
            this.label_movie_name.TabIndex = 0;
            this.label_movie_name.Text = "Movie Name:";
            // 
            // textedit_movie_name
            // 
            this.textedit_movie_name.Location = new System.Drawing.Point(160, 56);
            this.textedit_movie_name.Name = "textedit_movie_name";
            this.textedit_movie_name.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textedit_movie_name.Properties.Appearance.Options.UseFont = true;
            this.textedit_movie_name.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.textedit_movie_name.Size = new System.Drawing.Size(300, 24);
            this.textedit_movie_name.TabIndex = 1;
            // 
            // label_genre
            // 
            this.label_genre.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.label_genre.Appearance.Options.UseFont = true;
            this.label_genre.Location = new System.Drawing.Point(40, 110);
            this.label_genre.Name = "label_genre";
            this.label_genre.Size = new System.Drawing.Size(43, 16);
            this.label_genre.TabIndex = 2;
            this.label_genre.Text = "Genre:";
            // 
            // textedit_genre
            // 
            this.textedit_genre.Location = new System.Drawing.Point(160, 106);
            this.textedit_genre.Name = "textedit_genre";
            this.textedit_genre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textedit_genre.Properties.Appearance.Options.UseFont = true;
            this.textedit_genre.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.textedit_genre.Size = new System.Drawing.Size(300, 24);
            this.textedit_genre.TabIndex = 3;
            // 
            // label_release_date
            // 
            this.label_release_date.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.label_release_date.Appearance.Options.UseFont = true;
            this.label_release_date.Location = new System.Drawing.Point(40, 160);
            this.label_release_date.Name = "label_release_date";
            this.label_release_date.Size = new System.Drawing.Size(90, 16);
            this.label_release_date.TabIndex = 4;
            this.label_release_date.Text = "Release Date:";
            // 
            // dateedit_release_date
            // 
            this.dateedit_release_date.EditValue = null;
            this.dateedit_release_date.Location = new System.Drawing.Point(160, 156);
            this.dateedit_release_date.Name = "dateedit_release_date";
            this.dateedit_release_date.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dateedit_release_date.Properties.Appearance.Options.UseFont = true;
            this.dateedit_release_date.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.dateedit_release_date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateedit_release_date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateedit_release_date.Size = new System.Drawing.Size(300, 24);
            this.dateedit_release_date.TabIndex = 5;
            // 
            // label_runtime
            // 
            this.label_runtime.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.label_runtime.Appearance.Options.UseFont = true;
            this.label_runtime.Location = new System.Drawing.Point(40, 210);
            this.label_runtime.Name = "label_runtime";
            this.label_runtime.Size = new System.Drawing.Size(97, 16);
            this.label_runtime.TabIndex = 6;
            this.label_runtime.Text = "Runtime (min):";
            // 
            // numeric_runtime
            // 
            this.numeric_runtime.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.numeric_runtime.Location = new System.Drawing.Point(160, 206);
            this.numeric_runtime.Name = "numeric_runtime";
            this.numeric_runtime.Size = new System.Drawing.Size(300, 23);
            this.numeric_runtime.TabIndex = 7;
            // 
            // button_add
            // 
            this.button_add.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button_add.Appearance.Options.UseFont = true;
            this.button_add.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.button_add.Location = new System.Drawing.Point(160, 260);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(300, 45);
            this.button_add.TabIndex = 8;
            this.button_add.Text = "Add Movie Registry";
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 360);
            this.Controls.Add(this.groupControl_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddMovie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Movie";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_main)).EndInit();
            this.groupControl_main.ResumeLayout(false);
            this.groupControl_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textedit_movie_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textedit_genre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateedit_release_date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateedit_release_date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_runtime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl_main;
        private DevExpress.XtraEditors.LabelControl label_movie_name;
        private DevExpress.XtraEditors.TextEdit textedit_movie_name;
        private DevExpress.XtraEditors.LabelControl label_genre;
        private DevExpress.XtraEditors.TextEdit textedit_genre;
        private DevExpress.XtraEditors.LabelControl label_release_date;
        private DevExpress.XtraEditors.DateEdit dateedit_release_date;
        private DevExpress.XtraEditors.LabelControl label_runtime;
        private System.Windows.Forms.NumericUpDown numeric_runtime;
        private DevExpress.XtraEditors.SimpleButton button_add;
    }
}