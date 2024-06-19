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
    public class ConductoresController : ApiController
    {
        ConductoresNegocio conductoresNegocio = new ConductoresNegocio();

        public IHttpActionResult Get()
        {
            ConductoresNegocio conductoresNegocio = new ConductoresNegocio();
            var respuesta = conductoresNegocio.All();
            return Ok(respuesta);
        }

        public IHttpActionResult Get(int id)
        {
            Conductore conductores = conductoresNegocio.ByID(id);
            
            if(conductores != null)
            {
                return Ok(conductores);
            }
            return NotFound();
        }

        public IHttpActionResult Post(Conductore conductores)
        {
            conductoresNegocio.InsertarConductores(conductores);
            return Ok(conductores);
        }

        public IHttpActionResult Put(Conductore conductores)
        {
            conductoresNegocio.ActualizarConductores(conductores);
            return Ok(conductores);
        }

        public IHttpActionResult Delete(int id)
        {
            conductoresNegocio.EliminarConductores(id);
            return Ok();
        }
    }
}