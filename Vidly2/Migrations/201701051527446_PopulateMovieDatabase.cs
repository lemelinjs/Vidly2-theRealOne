namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovieDatabase : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('HANGOVER', 'Comedy', '2009-11-06','2016-05-04', '5')");
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('La belle et idiot', 'Comedy', '2009-10-06','2015-05-04', '3')");
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('Batman', 'Science Fiction', '2007-10-06','2017-01-01', '10')");
        }

        public override void Down()
        {
        }
    }
}
