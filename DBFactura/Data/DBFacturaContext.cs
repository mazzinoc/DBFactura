using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DBFactura.Models;

namespace DBFactura.Data
{
    public class DBFacturaContext:DbContext
    {
        //constructor
        public DBFacturaContext() : base("KeyDBFactura") { }

        //propiedades DbSet<m>

        public DbSet<FacturasItems> FacturaItems { get; set; }
        public DbSet<DocumentoComercial> DocumentoComerciales { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Items> Items { get; set; }

        public DbSet<Remito> Remitos { get; set; }


    }
}
