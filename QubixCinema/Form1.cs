using QubixCinema.DataAccess;
using System;
using System.Data.Entity;

namespace QubixCinema
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
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
    }
}
