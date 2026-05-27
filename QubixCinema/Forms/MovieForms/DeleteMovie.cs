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
        private readonly MovieService _movieService;

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
                XtraMessageBox.Show($"Load Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMovies()
        {
            try
            {
                List<Movie> movies = _movieService.GetAllMovies();
                
                // Hide EF virtual relations by projecting to a clean anonymous list
                var displayList = System.Linq.Enumerable.ToList(
                    System.Linq.Enumerable.Select(movies, m => new
                    {
                        MovieID = m.MovieId,
                        MovieName = m.MovieName,
                        Genre = m.Genre,
                        Runtime = $"{m.Runtime} mins",
                        ReleaseDate = m.ReleaseDate.ToString("yyyy-MM-dd")
                    })
                );

                grid_movies.DataSource = displayList;
                gridView1.BestFitColumns();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error loading movies: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            object movieIdObj = gridView1.GetFocusedRowCellValue("MovieID");
            if (movieIdObj != null && movieIdObj != DBNull.Value)
            {
                int movieId = Convert.ToInt32(movieIdObj);
                string movieName = Convert.ToString(gridView1.GetFocusedRowCellValue("MovieName"));

                DialogResult result = XtraMessageBox.Show($"Are you sure you want to delete the movie: '{movieName}'?",
                     "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        _movieService.DeleteMovie(movieId);
                        LoadMovies();
                        XtraMessageBox.Show("The movie has been successfully removed.",
                            "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show($"Failed to delete movie: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
