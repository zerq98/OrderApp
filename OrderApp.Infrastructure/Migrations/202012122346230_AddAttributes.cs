namespace OrderApp.Infrastructure.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddAttributes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "FirstName", c => c.String(nullable: false, maxLength: 63));
            AlterColumn("dbo.Orders", "Surname", c => c.String(nullable: false, maxLength: 63));
            AlterColumn("dbo.Orders", "BirthDate", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "Name", c => c.String(nullable: false, maxLength: 63));
        }

        public override void Down()
        {
            AlterColumn("dbo.Products", "Name", c => c.String());
            AlterColumn("dbo.Orders", "BirthDate", c => c.String());
            AlterColumn("dbo.Orders", "Surname", c => c.String());
            AlterColumn("dbo.Orders", "FirstName", c => c.String());
        }
    }
}