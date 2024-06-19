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
    public class PasajerosController : ApiController
    {
        PasajerosNegocio pasajerosNegocio = new PasajerosNegocio();

        public IHttpActionResult Get()
        {
            PasajerosNegocio pasajerosNegocio = new PasajerosNegocio();
            var respuesta = pasajerosNegocio.All();
            return Ok(respuesta);
        }

        public IHttpActionResult Get(int id)
        {
            Pasajero pasajeros = pasajerosNegocio.ByID(id);
            
            if(pasajeros != null)
            {
                return Ok(pasajeros);
            }
            return NotFound();
        }

        public IHttpActionResult Post(Pasajero pasajeros)
        {
            pasajerosNegocio.InsertarPasajeros(pasajeros);
            return Ok(pasajeros);
        }

        public IHttpActionResult Put(Pasajero pasajeros)
        {
            pasajerosNegocio.ActualizarPasajeros(pasajeros);
            return Ok(pasajeros);
        }

        public IHttpActionResult Delete(int id)
        {
            pasajerosNegocio.EliminarPasajeros(id);
            return Ok();
        }
    }
}