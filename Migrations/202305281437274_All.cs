namespace UpFit__main.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class All : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminID = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.AdminID);
            
            CreateTable(
                "dbo.AlimentsModels",
                c => new
                    {
                        AlimentID = c.Int(nullable: false, identity: true),
                        AlimentName = c.String(),
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
            
            CreateTable(
                "dbo.Coaches",
                c => new
                    {
                        CoachID = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CoachID);
            
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
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        SubscriptionTypeFK = c.Int(nullable: false),
                        UserName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Gender = c.String(),
                        Age = c.Int(nullable: false),
                        Height = c.Int(nullable: false),
                        Weight = c.Int(nullable: false),
                        KcalDaily = c.Int(nullable: false),
                        Lifestyle = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.UploadClasses",
                c => new
                    {
                        videoID = c.Int(nullable: false, identity: true),
                        Vname = c.String(),
                        Vpath = c.String(),
                    })
                .PrimaryKey(t => t.videoID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UploadClasses");
            DropTable("dbo.Users");
            DropTable("dbo.Meals");
            DropTable("dbo.Coaches");
            DropTable("dbo.AlimentsModels");
            DropTable("dbo.Admins");
        }
    }
}
