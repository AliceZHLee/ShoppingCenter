namespace ShoppingCenter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMemberTypeName : DbMigration
    {
        public override void Up()
        {
            Sql("Update MembershipTypes set name='Free as you go' where Id=1");
            Sql("Update Membershiptypes set name='Monthly subscriber' where id=2");
            Sql("Update Membershiptypes set name='Season subscriber' where id=3");
            Sql("Update Membershiptypes set name='Annual subscriber' where id=4");
        }
        
        public override void Down()
        {
        }
    }
}
