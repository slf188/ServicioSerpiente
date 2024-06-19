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
    public class BusesController : ApiController
    {
        BusesNegocio busesNegocio = new BusesNegocio();

        public IHttpActionResult Get()
        {
            BusesNegocio busesNegocio = new BusesNegocio();
            var respuesta = busesNegocio.All();
            return Ok(respuesta);
        }

        public IHttpActionResult Get(int id)
        {
            Bus buses = busesNegocio.ByID(id);
                
            if(buses != null)
            {
                return Ok(buses);
            }
            return NotFound();
        }

        public IHttpActionResult Post(Bus buses)
        {
            busesNegocio.InsertarBuses(buses);
            return Ok(buses);
        }

        public IHttpActionResult Put(Bus buses)
        {
            busesNegocio.ActualizarBuses(buses);
            return Ok(buses);
        }

        public IHttpActionResult Delete(int id)
        {
            busesNegocio.EliminarBuses(id);
            return Ok();
        }
    }
}