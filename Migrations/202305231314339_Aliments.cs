namespace UpFit__main.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Aliments : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aliments",
                c => new
                {
                    AlimentID = c.Int(nullable: false, identity: true),
                    AlimentName = c.String(nullable: false),
                    Kcal = c.Double(nullable: false),
                    Carbohidrates = c.Double(nullable: false),
                    Proteins = c.Double(nullable: false),
                    Fibers = c.Double(nullable: false),
                    VitA = c.Double(nullable: false),
                    VitB = c.Double(nullable: false),
                    VitC = c.Double(nullable: false),
                    Magnezium = c.Double(nullable: false),
                    Sodium = c.Double(nullable: false),
                })
                .PrimaryKey(t => t.AlimentID);

        }

        public override void Down()
        {
            DropTable("dbo.Aliments");
        }
    }
}
