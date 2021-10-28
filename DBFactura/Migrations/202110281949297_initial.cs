namespace DBFactura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DocumentosComerciales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Numero = c.Int(nullable: false),
                        Fecha = c.DateTime(nullable: false, storeType: "date"),
                        Cliente = c.String(maxLength: 50, unicode: false),
                        Direccion = c.String(maxLength: 100, unicode: false),
                        CondicionIva = c.String(maxLength: 50, unicode: false),
                        CondicionVenta = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Facturas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tipo = c.String(nullable: false, maxLength: 1, fixedLength: true, unicode: false),
                        DocumentoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DocumentosComerciales", t => t.DocumentoId, cascadeDelete: true)
                .Index(t => t.DocumentoId);
            
            CreateTable(
                "dbo.FacturasItems",
                c => new
                    {
                        ItemId = c.Int(nullable: false),
                        FacturaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ItemId, t.FacturaId })
                .ForeignKey("dbo.Facturas", t => t.FacturaId, cascadeDelete: true)
                .ForeignKey("dbo.Items", t => t.ItemId, cascadeDelete: true)
                .Index(t => t.ItemId)
                .Index(t => t.FacturaId);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PrecioUnitario = c.Int(nullable: false),
                        Cantidad = c.Int(nullable: false),
                        Importe = c.Int(nullable: false),
                        Descripcion = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Remito",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DocumentoId = c.Int(nullable: false),
                        FechaEntrega = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DocumentosComerciales", t => t.DocumentoId, cascadeDelete: true)
                .Index(t => t.DocumentoId);
            
            CreateTable(
                "dbo.RemitosItems",
                c => new
                    {
                        Id_Remito = c.Int(nullable: false),
                        Id_Item = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Id_Remito, t.Id_Item })
                .ForeignKey("dbo.Items", t => t.Id_Item, cascadeDelete: true)
                .ForeignKey("dbo.Remito", t => t.Id_Remito, cascadeDelete: true)
                .Index(t => t.Id_Remito)
                .Index(t => t.Id_Item);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RemitosItems", "Id_Remito", "dbo.Remito");
            DropForeignKey("dbo.RemitosItems", "Id_Item", "dbo.Items");
            DropForeignKey("dbo.Remito", "DocumentoId", "dbo.DocumentosComerciales");
            DropForeignKey("dbo.FacturasItems", "ItemId", "dbo.Items");
            DropForeignKey("dbo.FacturasItems", "FacturaId", "dbo.Facturas");
            DropForeignKey("dbo.Facturas", "DocumentoId", "dbo.DocumentosComerciales");
            DropIndex("dbo.RemitosItems", new[] { "Id_Item" });
            DropIndex("dbo.RemitosItems", new[] { "Id_Remito" });
            DropIndex("dbo.Remito", new[] { "DocumentoId" });
            DropIndex("dbo.FacturasItems", new[] { "FacturaId" });
            DropIndex("dbo.FacturasItems", new[] { "ItemId" });
            DropIndex("dbo.Facturas", new[] { "DocumentoId" });
            DropTable("dbo.RemitosItems");
            DropTable("dbo.Remito");
            DropTable("dbo.Items");
            DropTable("dbo.FacturasItems");
            DropTable("dbo.Facturas");
            DropTable("dbo.DocumentosComerciales");
        }
    }
}
