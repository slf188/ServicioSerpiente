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
    public class HorariosController : ApiController
    {
        HorariosNegocio horariosNegocio = new HorariosNegocio();

        public IHttpActionResult Get()
        {
            HorariosNegocio horariosNegocio = new HorariosNegocio();
            var respuesta = horariosNegocio.All();
            return Ok(respuesta);
        }

        public IHttpActionResult Get(int id)
        {
            Horario horarios = horariosNegocio.ByID(id);
            
            if(horarios != null)
            {
                return Ok(horarios);
            }
            return NotFound();
        }

        public IHttpActionResult Post(Horario horarios)
        {
            horariosNegocio.InsertarHorarios(horarios);
            return Ok(horarios);
        }

        public IHttpActionResult Put(Horario horarios)
        {
            horariosNegocio.ActualizarHorarios(horarios);
            return Ok(horarios);
        }

        public IHttpActionResult Delete(int id)
        {
            horariosNegocio.EliminarHorarios(id);
            return Ok();
        }
    }
}