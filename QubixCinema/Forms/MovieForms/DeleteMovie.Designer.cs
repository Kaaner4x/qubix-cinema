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
            this.grid_movies = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_movies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_movies
            // 
            this.grid_movies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_movies.Location = new System.Drawing.Point(0, 0);
            this.grid_movies.MainView = this.gridView1;
            this.grid_movies.Name = "grid_movies";
            this.grid_movies.Size = new System.Drawing.Size(1050, 450);
            this.grid_movies.TabIndex = 0;
            this.grid_movies.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grid_movies;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // DeleteMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 450);
            this.Controls.Add(this.grid_movies);
            this.Name = "DeleteMovie";
            this.Text = "Delete Movie Registry (Double Click to Delete)";
            this.Load += new System.EventHandler(this.DeleteMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_movies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grid_movies;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}