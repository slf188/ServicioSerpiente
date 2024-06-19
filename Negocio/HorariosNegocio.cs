using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Datos;

namespace Negocio
{
    public class HorariosNegocio
    {
        HorariosDatos horarios;

        public HorariosNegocio()
        {
            horarios = new HorariosDatos();
        }

        // all
        public List<Horario> All()
        {
            return horarios.Listar();
        }

        // byId
        public Horario ByID(int id)
        {
            return horarios.Listar().Where(x => x.ID_Horario == id).FirstOrDefault();
        }

        // insertarHorarios
        public bool InsertarHorarios(Horario item)
        {
            return horarios.Nuevo(item);
        }

        // eliminarHorarios
        public bool EliminarHorarios(int id)
        {
            Horario item = horarios.BuscarID(id);
            return horarios.Eliminar(item);
        }

        // actualizarHorarios
        public bool ActualizarHorarios(Horario item)
        {
            return horarios.Actualizar(item);
        }
    }
}
