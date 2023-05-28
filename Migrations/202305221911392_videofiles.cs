namespace UpFit__main.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class videofiles : DbMigration
    {
        public override void Up()
        {
            CreateTable(
               "dbo.videofiles",
               c => new
               {
                   videoID = c.Int(nullable: false, identity: true),
                   Vname = c.String(nullable: false),
                   Vpath = c.String(nullable: false),
                  
               })
               .PrimaryKey(t => t.videoID);

        }

        public override void Down()
        {
            DropTable("dbo.videofiles");
        }
    }
}
