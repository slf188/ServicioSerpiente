using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Datos;

namespace Negocio
{
    public class ReservasNegocio
    {
        ReservasDatos reservas;

        public ReservasNegocio()
        {
            reservas = new ReservasDatos();
        }

        // All
        public List<Reserva> All()
        {
            return reservas.Listar();
        }

        // ById
        public Reserva ByID(int id)
        {
            return reservas.Listar().Where(x => x.ID_Reserva == id).FirstOrDefault();
        }

        // InsertarReservas
        public bool InsertarReservas(Reserva item)
        {
            return reservas.Nuevo(item);
        }

        // EliminarReservas
        public bool EliminarReservas(int id)
        {
            Reserva item = reservas.BuscarID(id);
            return reservas.Eliminar(item);
        }

        // ActualizarReservas
        public bool ActualizarReservas(Reserva item)
        {
            return reservas.Actualizar(item);
        }


    }
}
