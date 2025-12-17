using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinal.v2.Models
{
    public class SolicitudResumen
    {
        public string Titulo { get; set; }
        public int Cantidad { get; set; }
        public DateTime UltimaSolicitud { get; set; }
    }
}