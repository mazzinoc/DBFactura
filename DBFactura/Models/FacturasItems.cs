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
        [Key, Column(Order = 0)]
        public int ItemId { get; set; }
        [ForeignKey("ItemId")]
        public Items item { get; set; }


        [Key, Column(Order = 1)]
        public int FacturaId { get; set; }
        [ForeignKey("FacturaId")]

        public Factura Factura { get; set; }
    }
}
