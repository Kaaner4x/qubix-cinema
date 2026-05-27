using QubixCinema.DataAccess;
using QubixCinema.Business.Services;
using QubixCinema.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
                
                // Hide virtual ICollection relations by projecting to a clean anonymous list
                var displayList = movies.Select(m => new
                {
                    MovieID = m.MovieId,
                    MovieName = m.MovieName,
                    Genre = m.Genre,
                    Runtime = $"{m.Runtime} mins",
                    ReleaseDate = m.ReleaseDate.ToString("yyyy-MM-dd")
                }).ToList();

                grid_movies.DataSource = displayList;

                // Auto-fit DevExpress GridView columns
                if (grid_movies.MainView is DevExpress.XtraGrid.Views.Grid.GridView gridView)
                {
                    gridView.BestFitColumns();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Error: {ex.Message}");
                throw;
            }
        }
    }
}
