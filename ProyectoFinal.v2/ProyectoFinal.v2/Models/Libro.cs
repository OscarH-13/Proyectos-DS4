using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProyectoFinal.v2.Models
{
    [Table("Libros")]
    public class Libro
    {
        [Key]
        public int LibroId { get; set; }

        [Required]
        public string Titulo { get; set; }

        [Required]
        public string Autor { get; set; }

        public int? AnioPublicacion { get; set; }

        [Required]
        public string Categoria { get; set; }

        public bool Disponible { get; set; }
    }
}