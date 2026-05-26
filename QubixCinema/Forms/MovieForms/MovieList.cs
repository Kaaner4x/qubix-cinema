using QubixCinema.DataAccess;
using QubixCinema.Business.Services;
using QubixCinema.Entities.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QubixCinema
{
    public partial class MovieList : Form
    {
        private MovieService _movieService;

        public MovieList()
        {
            InitializeComponent();
        }

        private void MovieList_Load(object sender, EventArgs e)
        {
            try
            {
                _movieService = new MovieService(new QubixCinemaContext());
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
    }
}
