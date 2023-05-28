namespace UpFit__main.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class Coaches : DbMigration
    {
        public override void Up()
        {
            CreateTable(
               "dbo.Coaches",
               c => new
               {
                   CoachID = c.Int(nullable: false, identity: true),
                   UserName = c.String(nullable: false),
                   Password = c.String(nullable: false),
               })
               .PrimaryKey(t => t.CoachID);
        }

        public override void Down()
        {
            DropTable("dbo.Coaches");
        }
    }
}