using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProyectoFinal.v2.Models
{
    [Table("Solicitudes")]
    public class Solicitud
    {
        [Key]
        public int SolicitudId { get; set; }

        [Required]
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int? AnioPublicacion { get; set; }
        public string Categoria { get; set; }
        public string NombreSolicitante { get; set; }
        public string CorreoSolicitante { get; set; }
        public string Comentario { get; set; }
        public DateTime FechaSolicitud { get; set; }
    }
}