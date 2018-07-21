namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedemployeeandDowmodels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DayOfWeeks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DoW = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customers", "DoWId", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "Balance", c => c.Double(nullable: false));
            CreateIndex("dbo.Customers", "DoWId");
            AddForeignKey("dbo.Customers", "DoWId", "dbo.DayOfWeeks", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "DoWId", "dbo.DayOfWeeks");
            DropIndex("dbo.Customers", new[] { "DoWId" });
            DropColumn("dbo.Customers", "Balance");
            DropColumn("dbo.Customers", "DoWId");
            DropTable("dbo.DayOfWeeks");
        }
    }
}
