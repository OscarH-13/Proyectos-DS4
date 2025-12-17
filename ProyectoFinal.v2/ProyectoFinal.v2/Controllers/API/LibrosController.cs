using ProyectoFinal.v2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProyectoFinal.v2.Controllers.API
{
    public class LibrosController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get(string texto = "")
        {
            texto = (texto ?? "").Trim();

            using (var db = new BibliotecaContexto())
            {
                var resultado = db.Libros
                    .Where(l => l.Titulo.Contains(texto) || l.Autor.Contains(texto))
                    .OrderBy(l => l.Titulo)
                    .Take(20)
                    .ToList();

                return Ok(resultado);
            }
        }
    }
}

