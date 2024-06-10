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
        public List<Reservas> Listar()
        {
            return reservas.Listar();
        }

        // ById
        public Reservas ById(int id)
        {
            return reservas.Listar().Where(x => x.ID_Reserva == id).FirstOrDefault();
        }

        // InsertarReservas
        public bool InsertartReservas(Reservas item)
        {
            return reservas.Nuevo(item);
        }

        // EliminarReservas
        public bool EliminarReservas(Reservas item)
        {
            return reservas.Eliminar(item);
        }

        // ActualizarReservas
        public bool ActualizarReservas(Reservas item)
        {
            return reservas.Actualizar(item);
        }


    }
}
