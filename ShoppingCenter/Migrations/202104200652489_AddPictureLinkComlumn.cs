namespace ShoppingCenter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPictureLinkComlumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductPictures", "PictureLink", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProductPictures", "PictureLink");
        }
    }
}
