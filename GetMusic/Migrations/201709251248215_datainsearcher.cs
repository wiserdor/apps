namespace GetMusic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datainsearcher : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Searchers", "Album_Id", c => c.Int());
            AddColumn("dbo.Searchers", "artist_Id", c => c.Int());
            AddColumn("dbo.Searchers", "track_Id", c => c.Int());
            CreateIndex("dbo.Searchers", "Album_Id");
            CreateIndex("dbo.Searchers", "artist_Id");
            CreateIndex("dbo.Searchers", "track_Id");
            AddForeignKey("dbo.Searchers", "Album_Id", "dbo.Albums", "Id");
            AddForeignKey("dbo.Searchers", "artist_Id", "dbo.Artists", "Id");
            AddForeignKey("dbo.Searchers", "track_Id", "dbo.Tracks", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Searchers", "track_Id", "dbo.Tracks");
            DropForeignKey("dbo.Searchers", "artist_Id", "dbo.Artists");
            DropForeignKey("dbo.Searchers", "Album_Id", "dbo.Albums");
            DropIndex("dbo.Searchers", new[] { "track_Id" });
            DropIndex("dbo.Searchers", new[] { "artist_Id" });
            DropIndex("dbo.Searchers", new[] { "Album_Id" });
            DropColumn("dbo.Searchers", "track_Id");
            DropColumn("dbo.Searchers", "artist_Id");
            DropColumn("dbo.Searchers", "Album_Id");
        }
    }
}
