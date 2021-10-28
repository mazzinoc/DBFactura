using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DBFactura.Models;


namespace DBFactura.Models
{
    public class Factura
    {
        public int Id { get; set; }        

        [Required]
        [Column(TypeName = "char")]
        [MaxLength(1)]
        public string Tipo { get; set; }

        public List<FacturasItems> FacturasItems { get; set; }
        public int DocumentoId { get; set; }
        [ForeignKey("DocumentoId")]
        public DocumentoComercial DocumentoComercial { get; set; }

    }
}
