namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cleanedupcustomermodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Phone", c => c.String(nullable: false));
            AddColumn("dbo.Customers", "SuspendEndDate", c => c.DateTime());
            AlterColumn("dbo.Customers", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "StreetAddress", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "City", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "State", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "SpecialPUDate", c => c.DateTime());
            AlterColumn("dbo.Customers", "SuspendStartDate", c => c.DateTime());
            DropColumn("dbo.Customers", "EmailAddress");
            DropColumn("dbo.Customers", "AltContact");
            DropColumn("dbo.Customers", "WastePremContact");
            DropColumn("dbo.Customers", "WastePremStreetAddress");
            DropColumn("dbo.Customers", "WastePremCity");
            DropColumn("dbo.Customers", "WastePremState");
            DropColumn("dbo.Customers", "WastePremZip");
            DropColumn("dbo.Customers", "HomeAreaCode");
            DropColumn("dbo.Customers", "HomePhone");
            DropColumn("dbo.Customers", "MobileAreaCode");
            DropColumn("dbo.Customers", "MobilePhone");
            DropColumn("dbo.Customers", "WorkAreaCode");
            DropColumn("dbo.Customers", "WorkPhone");
            DropColumn("dbo.Customers", "FaxAreaCode");
            DropColumn("dbo.Customers", "FaxPhone");
            DropColumn("dbo.Customers", "WastePremAreaCode");
            DropColumn("dbo.Customers", "WastePremPhone");
            DropColumn("dbo.Customers", "GPSLatitude");
            DropColumn("dbo.Customers", "GPSLongitude");
            DropColumn("dbo.Customers", "Comments");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Comments", c => c.String());
            AddColumn("dbo.Customers", "GPSLongitude", c => c.Single(nullable: false));
            AddColumn("dbo.Customers", "GPSLatitude", c => c.Single(nullable: false));
            AddColumn("dbo.Customers", "WastePremPhone", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "WastePremAreaCode", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "FaxPhone", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "FaxAreaCode", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "WorkPhone", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "WorkAreaCode", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "MobilePhone", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "MobileAreaCode", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "HomePhone", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "HomeAreaCode", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "WastePremZip", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "WastePremState", c => c.String());
            AddColumn("dbo.Customers", "WastePremCity", c => c.String());
            AddColumn("dbo.Customers", "WastePremStreetAddress", c => c.String());
            AddColumn("dbo.Customers", "WastePremContact", c => c.String());
            AddColumn("dbo.Customers", "AltContact", c => c.String());
            AddColumn("dbo.Customers", "EmailAddress", c => c.String());
            AlterColumn("dbo.Customers", "SuspendStartDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Customers", "SpecialPUDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Customers", "State", c => c.String());
            AlterColumn("dbo.Customers", "City", c => c.String());
            AlterColumn("dbo.Customers", "StreetAddress", c => c.String());
            AlterColumn("dbo.Customers", "LastName", c => c.String());
            AlterColumn("dbo.Customers", "FirstName", c => c.String());
            DropColumn("dbo.Customers", "SuspendEndDate");
            DropColumn("dbo.Customers", "Phone");
        }
    }
}
