using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBFactura.Models
{
    public class FacturasItems
    {   
        [Key]
        public int IdFacturaItem { get; set; }
        public int ItemId { get; set; }
        [ForeignKey("ItemId")]
        public Items item { get; set; }

        public int FacturaId { get; set; }
        [ForeignKey("FacturaId")]

        public Factura Factura { get; set; }
    }
}
