namespace DBFactura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update1 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.FacturasItems");
            AddPrimaryKey("dbo.FacturasItems", new[] { "ItemId", "FacturaId" });
            DropColumn("dbo.FacturasItems", "IdFacturaItem");
        }
        
        public override void Down()
        {
            AddColumn("dbo.FacturasItems", "IdFacturaItem", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.FacturasItems");
            AddPrimaryKey("dbo.FacturasItems", "IdFacturaItem");
        }
    }
}
