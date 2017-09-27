namespace GetMusic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addSreacher : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Searchers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Searchers");
        }
    }
}
