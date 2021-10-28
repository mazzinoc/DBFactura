﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DBFactura.Models;


namespace DBFactura.Models
{
    [Table("Items")]

    public class Items
    {
        public int Id { get; set; }
        public int PrecioUnitario { get; set; }
        public int Cantidad { get; set; }
        public int Importe { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Descripcion { get; set; }


        //public int FacturaItemId { get; set; }
        //[ForeignKey("FacturaItemId")]
        //public FacturasItems FacturasItems { get; set;}

        //[ForeignKey("RemitoItemsId")]
        //public RemitoItems RemitoItems { get; set;}

    }
}
