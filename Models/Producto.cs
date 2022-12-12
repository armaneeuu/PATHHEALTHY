using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PATHHEALTHY.Models
{
    [Table("t_product")]

    public class Producto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]

        public int Id {get;set;}

        [Column("nombre")]
        public string Nombre {get;set;}
        
        [Column("Imagen")]
        public String ImagenNombre {get;set;}

        [Column("precio")]
        public Decimal Precio {get;set;}

        [Column("Descripcion")]
        public string Descripcion {get;set;}

        [Column("fecha")]
        public DateTime Fecha {get; set;}

        [Column("estado")]
        public String Estado {get;set;}
    }
}