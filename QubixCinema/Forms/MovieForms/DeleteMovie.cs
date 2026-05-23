using DevExpress.XtraEditors;
using QubixCinema.DataAccess;
using QubixCinema.DataAccess.Services;
using QubixCinema.Entities.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QubixCinema.Forms.MovieForms
{
    public partial class DeleteMovie : Form
    {
        private readonly MovieService _movieService;
        public DeleteMovie()
        {
            InitializeComponent();
            _movieService = new MovieService(new QubixCinemaContext());
        }

        private void DeleteMovie_Load(object sender, EventArgs e)
        {
            LoadMovies();
        }

        private void LoadMovies()
        {
            try
            {
                List<Movie> movies = _movieService.GetAllMovies();
                grid_movies.DataSource = movies;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Error: {ex.Message}");
                throw;
            }
        }

        private void grid_movies_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow chosenRow = grid_movies.CurrentRow;
            int movie = Convert.ToInt32(chosenRow.Cells[0].Value);

            DialogResult result = XtraMessageBox.Show("Are you sure you want to delete the selected movie?",
                 "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _movieService.DeleteMovie(movie);
                LoadMovies();
                XtraMessageBox.Show("The movie has been successfully removed",
                "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
