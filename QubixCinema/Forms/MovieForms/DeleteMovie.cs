using DevExpress.XtraEditors;
using QubixCinema.Business.Services;
using QubixCinema.DataAccess;
using QubixCinema.Entities.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QubixCinema.Forms.MovieForms
{
    public partial class DeleteMovie : Form
    {
        private MovieService _movieService;
        public DeleteMovie()
        {
            InitializeComponent();
            _movieService = new MovieService(new QubixCinemaContext());
        }

        private void DeleteMovie_Load(object sender, EventArgs e)
        {
            try
            {
                LoadMovies();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Load Error: {ex.ToString()}");
            }
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
            if (grid_movies.CurrentRow?.DataBoundItem is Movie chosenMovie)
            {
                int movie = chosenMovie.MovieId;

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
}
