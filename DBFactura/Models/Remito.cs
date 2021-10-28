using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBFactura.Models
{
    [Table("Remito")]
    public class Remito
    {
        [Key]
        public int Id { get; set; }
        public int DocumentoId { get; set; }

        [ForeignKey("DocumentoId")]
        public DocumentoComercial DocumentoComercial { get; set; }

        [Column(TypeName = "date")]
        public DateTime FechaEntrega { get; set; }

        public List<RemitoItem> RemitoItems { get; set; }
    }
}
