using DevExpress.XtraEditors;
using QubixCinema.Business.Services;
using QubixCinema.Entities.Models;
using System;
using System.Windows.Forms;

namespace QubixCinema.Forms.MovieForms
{
    public partial class UpdateMovie : Form
    {
        private MovieService _movieService;

        public UpdateMovie()
        {
            InitializeComponent();
            _movieService = new MovieService(new DataAccess.QubixCinemaContext());
            numeric_runtime.Maximum = 1000;
        }

        private void UpdateMovie_Load(object sender, EventArgs e)
        {
            try
            {
                var movies = _movieService.GetAllMovies();

                combobox_movie.DataSource = movies;
                combobox_movie.DisplayMember = "MovieName";
                combobox_movie.ValueMember = "MovieId";
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Load Error: {ex.ToString()}");
            }
        }

        private void combobox_movie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combobox_movie.SelectedItem is Movie chosenMovie)
            {
                textedit_movie_name.Text = chosenMovie.MovieName;
                textedit_genre.Text = chosenMovie.Genre;
                numeric_runtime.Value = chosenMovie.Runtime;
                dateedit_release_date.DateTime = chosenMovie.ReleaseDate;
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (combobox_movie.SelectedItem is Movie chosenMovie)
            {
                chosenMovie.MovieName = textedit_movie_name.Text;
                chosenMovie.Genre = textedit_genre.Text;
                chosenMovie.Runtime = Convert.ToInt32(numeric_runtime.Value);
                chosenMovie.ReleaseDate = dateedit_release_date.DateTime;

                _movieService.UpdateMovie(chosenMovie);

                XtraMessageBox.Show("The movie has been successfully updated",
                  "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
