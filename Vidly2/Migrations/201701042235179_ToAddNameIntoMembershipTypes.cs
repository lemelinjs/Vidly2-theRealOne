namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ToAddNameIntoMembershipTypes : DbMigration
    {
        public override void Up()
        {
            //string value1 = "pay as you go";
            Sql("UPDATE MembershipTypes SET Name = 'Monthly' WHERE Id = 2");
            Sql("UPDATE MembershipTypes SET Name = 'Quarterly' WHERE Id = 3");
            Sql("UPDATE MembershipTypes SET Name = 'Yearly' WHERE Id = 4");



        }

        public override void Down()
        {
        }
    }
}
