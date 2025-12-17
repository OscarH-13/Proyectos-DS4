using ProyectoFinal.v2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProyectoFinal.v2.Controllers.API
{
    public class SolicitudesController : ApiController
    {
        [HttpPost]
        public IHttpActionResult Post(Solicitud solicitud)
        {
            if (solicitud == null || string.IsNullOrWhiteSpace(solicitud.Titulo))
                return BadRequest("El título es obligatorio.");

            solicitud.Titulo = solicitud.Titulo.Trim();
            solicitud.FechaSolicitud = DateTime.Now;

            using (var db = new BibliotecaContexto())
            {
                db.Solicitudes.Add(solicitud);
                db.SaveChanges();
            }

            return Ok(new { mensaje = "Solicitud enviada correctamente." });
        }

        [HttpGet]
        [Route("api/solicitudes/resumen")]
        public IHttpActionResult Resumen()
        {
            using (var db = new BibliotecaContexto())
            {
                var lista = db.Solicitudes
                    .GroupBy(s => s.Titulo)
                    .Select(g => new SolicitudResumen
                    {
                        Titulo = g.Key,
                        Cantidad = g.Count(),
                        UltimaSolicitud = g.Max(x => x.FechaSolicitud)
                    })
                    .OrderByDescending(x => x.Cantidad)
                    .ThenBy(x => x.Titulo)
                    .ToList();

                return Ok(lista);
            }
        }
    }
}
