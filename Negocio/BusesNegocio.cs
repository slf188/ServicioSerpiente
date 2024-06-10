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
        BusesDatos buses;

        public BusesNegocio()
        {
            buses = new BusesDatos();
        }

        // All
        public List<Buses> All()
        {
            return buses.Listar();
        }

        // ById
        public Buses ById(int id)
        {
            return buses.Listar().Where(x => x.ID_Bus == id).FirstOrDefault();
        }

        // InsertarBuses
        public bool InsertarBuses(Buses item)
        {
            return buses.Nuevo(item);
        }

        // EliminarBuses
        public bool EliminarBuses(Buses item)
        {
            return buses.Eliminar(item);
        }

        // ActualizarBuses
        public bool ActualizarBuses(Buses item)
        {
            return buses.Actualizar(item);
        }
    }
}
