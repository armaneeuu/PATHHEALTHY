using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PATHHEALTHY.Models
{
    [Table("t_contacto")]
    public class Contacto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set;}
        [Column("name")]
        public string Nombre {get; set;}
        [Column("email")]
        public string Correo { get; set;}
        [Column("phone")]
        public string Teléfono {get; set;}
        [Column("comment")]
        public string Comentario {get; set;}    
    }
}