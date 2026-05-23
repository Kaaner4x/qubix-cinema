using QubixCinema.DataAccess;
using QubixCinema.DataAccess.Services;
using QubixCinema.Forms.MovieForms;
using System;
using System.Data.Entity;

namespace QubixCinema
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        private readonly MovieService _movieService;

        public Form1()
        {
            _movieService = new MovieService(new QubixCinemaContext());
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Veri tabanı mevcut değilse oluşturur. Mevcut ise hiçbir şey yapmaz,
            // mevcut veri tabanına dokunmaz
            Database.SetInitializer(new CreateDatabaseIfNotExists<QubixCinemaContext>());

            using (var database = new QubixCinemaContext())
            {
                database.Database.Initialize(force: true);
            }
        }

        private void bar_button_list_movies_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MovieList ml = new MovieList();
            ml.MdiParent = this;
            ml.Show();
        }

        private void bar_button_add_movies_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddMovie am = new AddMovie();
            am.MdiParent = this;
            am.Show();
        }

        private void bar_button_update_movies_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UpdateMovie um = new UpdateMovie();
            um.MdiParent = this;
            um.Show();
        }

        private void bar_button_delete_movies_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteMovie dm = new DeleteMovie();
            dm.MdiParent = this;
            dm.Show();
        }
    }
}
