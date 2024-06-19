using AccesoDatos;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace ApiREST.Controllers
{
    public class RutasController : ApiController
    {
        RutasNegocio rutasNegocio = new RutasNegocio();

        public IHttpActionResult Get()
        {
            RutasNegocio rutasNegocio = new RutasNegocio();
            var respuesta = rutasNegocio.All();
            return Ok(respuesta);
        }

        public IHttpActionResult Get(int id)
        {
            Ruta rutas = rutasNegocio.ByID(id);
            
            if(rutas != null)
            {
                return Ok(rutas);
            }
            return NotFound();
        }

        public IHttpActionResult Post(Ruta rutas)
        {
            rutasNegocio.InsertarRutas(rutas);
            return Ok(rutas);
        }

        public IHttpActionResult Put(Ruta rutas)
        {
            rutasNegocio.ActualizarRutas(rutas);
            return Ok(rutas);
        }

        public IHttpActionResult Delete(int id)
        {
            rutasNegocio.EliminarRutas(id);
            return Ok();
        }
    }
}