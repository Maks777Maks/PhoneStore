namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initsial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        time = c.DateTime(nullable: false),
                        phone_ID = c.Int(nullable: false),
                        user_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Phones", t => t.phone_ID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.user_ID, cascadeDelete: true)
                .Index(t => t.phone_ID)
                .Index(t => t.user_ID);
            
            CreateTable(
                "dbo.Phones",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Mark = c.String(nullable: false),
                        Model = c.String(nullable: false),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Mail = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "user_ID", "dbo.Users");
            DropForeignKey("dbo.Orders", "phone_ID", "dbo.Phones");
            DropIndex("dbo.Orders", new[] { "user_ID" });
            DropIndex("dbo.Orders", new[] { "phone_ID" });
            DropTable("dbo.Users");
            DropTable("dbo.Phones");
            DropTable("dbo.Orders");
        }
    }
}
