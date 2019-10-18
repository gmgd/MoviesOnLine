namespace MoviesOnLine.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class movie_created : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        MovieId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Duration = c.Single(nullable: false),
                        Year = c.Int(nullable: false),
                        Director = c.String(),
                    })
                .PrimaryKey(t => t.MovieId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Movies");
        }
    }
}
