namespace OrderApp.Infrastructure.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddOrderDateColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "DateOfOrder", c => c.DateTime(nullable: false));
        }

        public override void Down()
        {
            DropColumn("dbo.Orders", "DateOfOrder");
        }
    }
}