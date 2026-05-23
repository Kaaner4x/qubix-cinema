namespace QubixCinema.DataAccess.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                {
                    CustomerId = c.Int(nullable: false, identity: true),
                    CustomerFirstName = c.String(nullable: false, maxLength: 50),
                    CustomerLastName = c.String(nullable: false, maxLength: 50),
                    PhoneNumber = c.String(nullable: false, maxLength: 50),
                    Email = c.String(nullable: false, maxLength: 50),
                })
                .PrimaryKey(t => t.CustomerId);

            CreateTable(
                "dbo.Reservations",
                c => new
                {
                    ReservationId = c.Int(nullable: false, identity: true),
                    MovieId = c.Int(nullable: false),
                    CustomerId = c.Int(nullable: false),
                    SeatId = c.Int(nullable: false),
                    ReservationDate = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.ReservationId)
                .ForeignKey("dbo.Movies", t => t.MovieId)
                .ForeignKey("dbo.Seats", t => t.SeatId)
                .ForeignKey("dbo.Customers", t => t.CustomerId)
                .Index(t => t.MovieId)
                .Index(t => t.CustomerId)
                .Index(t => t.SeatId);

            CreateTable(
                "dbo.Movies",
                c => new
                {
                    MovieId = c.Int(nullable: false, identity: true),
                    MovieName = c.String(nullable: false, maxLength: 75),
                    Genre = c.String(nullable: false, maxLength: 50),
                    Runtime = c.Int(nullable: false),
                    ReleaseDate = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.MovieId);

            CreateTable(
                "dbo.Seats",
                c => new
                {
                    SeatId = c.Int(nullable: false, identity: true),
                    HallName = c.String(nullable: false, maxLength: 50),
                    SerialNumber = c.Int(nullable: false),
                    SeatNumber = c.Int(nullable: false),
                    isBooked = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.SeatId);

            CreateTable(
                "dbo.Register",
                c => new
                {
                    RegisterId = c.Int(nullable: false, identity: true),
                    Amount = c.Decimal(nullable: false, storeType: "money"),
                    Description = c.String(nullable: false, maxLength: 200),
                    TransactionDate = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.RegisterId);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Reservations", "SeatId", "dbo.Seats");
            DropForeignKey("dbo.Reservations", "MovieId", "dbo.Movies");
            DropIndex("dbo.Reservations", new[] { "SeatId" });
            DropIndex("dbo.Reservations", new[] { "CustomerId" });
            DropIndex("dbo.Reservations", new[] { "MovieId" });
            DropTable("dbo.Register");
            DropTable("dbo.Seats");
            DropTable("dbo.Movies");
            DropTable("dbo.Reservations");
            DropTable("dbo.Customers");
        }
    }
}
