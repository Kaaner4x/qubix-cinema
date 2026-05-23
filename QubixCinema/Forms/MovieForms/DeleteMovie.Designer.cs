namespace QubixCinema.Forms.MovieForms
{
    partial class DeleteMovie
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
            this.grid_movies = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_movies)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_movies
            // 
            this.grid_movies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_movies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_movies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_movies.Location = new System.Drawing.Point(0, 0);
            this.grid_movies.Name = "grid_movies";
            this.grid_movies.ReadOnly = true;
            this.grid_movies.Size = new System.Drawing.Size(1050, 450);
            this.grid_movies.TabIndex = 0;
            this.grid_movies.DoubleClick += new System.EventHandler(this.grid_movies_DoubleClick);
            // 
            // DeleteMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 450);
            this.Controls.Add(this.grid_movies);
            this.Name = "DeleteMovie";
            this.Text = "Delete a movie";
            this.Load += new System.EventHandler(this.DeleteMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_movies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_movies;
    }
}