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
    public class ReservasController : ApiController
    {
        ReservasNegocio reservasNegocio = new ReservasNegocio();

        public IHttpActionResult Get()
        {
            ReservasNegocio reservasNegocio = new ReservasNegocio();
            var respuesta = reservasNegocio.All();
            return Ok(respuesta);
        }

        public IHttpActionResult Get(int id)
        {
            Reserva reservas = reservasNegocio.ByID(id);
            
            if(reservas != null)
            {
                return Ok(reservas);
            }
            return NotFound();
        }

        public IHttpActionResult Post(Reserva reservas)
        {
            reservasNegocio.InsertarReservas(reservas);
            return Ok(reservas);
        }

        public IHttpActionResult Put(Reserva reservas)
        {
            reservasNegocio.ActualizarReservas(reservas);
            return Ok(reservas);
        }

        public IHttpActionResult Delete(int id)
        {
            reservasNegocio.EliminarReservas(id);
            return Ok();
        }
    }
}