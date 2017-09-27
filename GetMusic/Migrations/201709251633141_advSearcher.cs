namespace GetMusic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class advSearcher : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Searchers", "Album_Id", "dbo.Albums");
            DropForeignKey("dbo.Searchers", "artist_Id", "dbo.Artists");
            DropForeignKey("dbo.Searchers", "track_Id", "dbo.Tracks");
            DropIndex("dbo.Searchers", new[] { "Album_Id" });
            DropIndex("dbo.Searchers", new[] { "artist_Id" });
            DropIndex("dbo.Searchers", new[] { "track_Id" });
            AddColumn("dbo.Searchers", "Type", c => c.String());
            AddColumn("dbo.Searchers", "AlbumName", c => c.String());
            AddColumn("dbo.Searchers", "TrackName", c => c.String());
            AddColumn("dbo.Searchers", "ArtistName", c => c.String());
            DropColumn("dbo.Searchers", "Album_Id");
            DropColumn("dbo.Searchers", "artist_Id");
            DropColumn("dbo.Searchers", "track_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Searchers", "track_Id", c => c.Int());
            AddColumn("dbo.Searchers", "artist_Id", c => c.Int());
            AddColumn("dbo.Searchers", "Album_Id", c => c.Int());
            DropColumn("dbo.Searchers", "ArtistName");
            DropColumn("dbo.Searchers", "TrackName");
            DropColumn("dbo.Searchers", "AlbumName");
            DropColumn("dbo.Searchers", "Type");
            CreateIndex("dbo.Searchers", "track_Id");
            CreateIndex("dbo.Searchers", "artist_Id");
            CreateIndex("dbo.Searchers", "Album_Id");
            AddForeignKey("dbo.Searchers", "track_Id", "dbo.Tracks", "Id");
            AddForeignKey("dbo.Searchers", "artist_Id", "dbo.Artists", "Id");
            AddForeignKey("dbo.Searchers", "Album_Id", "dbo.Albums", "Id");
        }
    }
}
