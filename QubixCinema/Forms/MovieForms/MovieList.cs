using QubixCinema.DataAccess;
using QubixCinema.DataAccess.Services;
using QubixCinema.Entities.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QubixCinema
{
    public partial class MovieList : Form
    {
        private readonly MovieService _movieService;

        public MovieList()
        {
            _movieService = new MovieService(new QubixCinemaContext());
            InitializeComponent();
        }

        private void MovieList_Load(object sender, EventArgs e)
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
    }
}
