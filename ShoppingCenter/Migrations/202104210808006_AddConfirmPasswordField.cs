namespace ShoppingCenter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddConfirmPasswordField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "ConfirmPassword", c => c.String());
            AlterColumn("dbo.Customers", "Password", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Password", c => c.String());
            DropColumn("dbo.Customers", "ConfirmPassword");
        }
    }
}
