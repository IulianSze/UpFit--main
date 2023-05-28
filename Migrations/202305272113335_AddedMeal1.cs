namespace UpFit__main.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMeal1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Meals",
                c => new
                    {
                        mealID = c.Int(nullable: false, identity: true),
                        mealTypeFK = c.Int(nullable: false),
                        userFK = c.Int(nullable: false),
                        foodFK = c.Int(nullable: false),
                        quantity = c.Int(nullable: false),
                        date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.mealID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Meals");
        }
    }
}
