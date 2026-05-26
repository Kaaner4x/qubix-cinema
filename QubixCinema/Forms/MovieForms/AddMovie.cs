using DevExpress.XtraEditors;
using QubixCinema.Business.Services;
using QubixCinema.Entities.Models;
using System;
using System.Windows.Forms;

namespace QubixCinema.Forms.MovieForms
{
    public partial class AddMovie : Form
    {
        private MovieService _movieService;

        public AddMovie()
        {
            InitializeComponent();
            numeric_runtime.Maximum = 1000;
        }

        private void button_add_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (_movieService == null)
                {
                    _movieService = new MovieService(new DataAccess.QubixCinemaContext());
                }
                var newMovie = new Movie
                {
                    MovieName = textedit_movie_name.Text,
                    Genre = textedit_genre.Text,
                    ReleaseDate = dateedit_release_date.DateTime,
                    Runtime = Convert.ToInt32(numeric_runtime.Value)
                };
                _movieService.AddMovie(newMovie);

                XtraMessageBox.Show("The movie has been successfully added",
                    "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show($"An error occurred while adding " +
                    $"the video: {ex.Message}", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
