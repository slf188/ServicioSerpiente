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
    public class TicketsController : ApiController
    {
        TicketsNegocio ticketsNegocio = new TicketsNegocio();

        public IHttpActionResult Get()
        {
            TicketsNegocio ticketsNegocio = new TicketsNegocio();
            var respuesta = ticketsNegocio.All();
            return Ok(respuesta);
        }

        public IHttpActionResult Get(int id)
        {
            Ticket tickets = ticketsNegocio.ByID(id);
            
            if(tickets != null)
            {
                return Ok(tickets);
            }
            return NotFound();
        }

        public IHttpActionResult Post(Ticket tickets)
        {
            ticketsNegocio.InsertarTickets(tickets);
            return Ok(tickets);
        }

        public IHttpActionResult Put(Ticket tickets)
        {
            ticketsNegocio.ActualizarTickets(tickets);
            return Ok(tickets);
        }

        public IHttpActionResult Delete(int id)
        {
            ticketsNegocio.EliminarTickets(id);
            return Ok();
        }
    }
}