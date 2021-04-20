namespace ShoppingCenter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPictureToProductClass : DbMigration 
    {
        //因为这一步是在在Product class中加入List<ProductPicture> 之后进行的migration，
        //所以说明在主表的class中加外表对应的外键是不会更改数据库的结构的
        public override void Up()
        {
        }
        
        public override void Down()
        {
        }
    }
}
