namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedComments : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Comments", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Comments");
        }
    }
}
