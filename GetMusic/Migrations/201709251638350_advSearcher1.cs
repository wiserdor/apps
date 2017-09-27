namespace GetMusic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class advSearcher1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tracks", "ArtistName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tracks", "ArtistName");
        }
    }
}
