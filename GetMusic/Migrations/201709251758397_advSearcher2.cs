namespace GetMusic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class advSearcher2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tracks", "AlbumName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tracks", "AlbumName");
        }
    }
}
