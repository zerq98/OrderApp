namespace OrderApp.Infrastructure.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddOrderTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    FirstName = c.String(),
                    Surname = c.String(),
                    BirthDate = c.String(),
                    Order_Id = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.Order_Id)
                .Index(t => t.Order_Id);

            AddColumn("dbo.Products", "OrderId", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "OrderId");
            AddForeignKey("dbo.Products", "OrderId", "dbo.Orders", "Id", cascadeDelete: true);
        }

        public override void Down()
        {
            DropForeignKey("dbo.Products", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.Orders", "Order_Id", "dbo.Orders");
            DropIndex("dbo.Products", new[] { "OrderId" });
            DropIndex("dbo.Orders", new[] { "Order_Id" });
            DropColumn("dbo.Products", "OrderId");
            DropTable("dbo.Orders");
        }
    }
}