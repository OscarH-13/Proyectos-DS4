using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProyectoFinal.v2.Models
{
    public class BibliotecaContexto : DbContext
    {
        public BibliotecaContexto() : base("name=BibliotecaConexion")
        {
        }

        public DbSet<Libro> Libros { get; set; }
        public DbSet<Solicitud> Solicitudes { get; set; }
    }
}