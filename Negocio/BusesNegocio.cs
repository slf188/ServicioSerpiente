using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Datos;

namespace Negocio
{
    public class BusesNegocio
    {
        BusDatos buses;

        public BusesNegocio()
        {
            buses = new BusDatos();
        }

        // All
        public List<Bus> All()
        {
            return buses.Listar();
        }

        // ById
        public Bus ByID(int id)
        {
            return buses.Listar().Where(x => x.ID_Bus == id).FirstOrDefault();
        }

        // InsertarBuses
        public bool InsertarBuses(Bus item)
        {
            return buses.Nuevo(item);
        }

        // EliminarBuses
        public bool EliminarBuses(int id)
        {
            Bus bus = buses.BuscarID(id);
            return buses.Eliminar(bus);
        }

        // ActualizarBuses
        public bool ActualizarBuses(Bus item)
        {
            return buses.Actualizar(item);
        }
    }
}
