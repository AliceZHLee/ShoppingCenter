namespace ShoppingCenter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColumnToCustomer_DOB : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "DOB", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "DOB");
        }
    }
}
