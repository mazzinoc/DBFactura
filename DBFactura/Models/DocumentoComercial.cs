using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DBFactura.Models
{
    [Table("DocumentosComerciales")]

    public class DocumentoComercial
    {
        [Key]
        public int Id { get; set; }
        public int Numero { get; set; }

        [Required]

        [Column(TypeName = "date")]
        public DateTime Fecha { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Cliente { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(100)]
        public string Direccion { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string CondicionIva { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string CondicionVenta { get; set; }

        //public int FacturaId { get; set; }
        //[ForeignKey("FacturaId")]
        //public Factura Factura { get; set; }

        public List<Factura> Facturas { get; set; }

        public List<Remito> Remitos { get; set; }
    }
}
