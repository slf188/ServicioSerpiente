using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Datos;

namespace Negocio
{
    public class PasajerosNegocio
    {
        PasajerosDatos pasajeros;

        public PasajerosNegocio()
        {
            pasajeros = new PasajerosDatos();
        }

        // All
        public List<Pasajero> All()
        {
            return pasajeros.Listar();
        }

        // ById
        public Pasajero ByID(int id)
        {
            return pasajeros.Listar().Where(x => x.ID_Pasajero == id).FirstOrDefault();
        }

        // InsertarPasajeros
        public bool InsertarPasajeros(Pasajero item)
        {
            return pasajeros.Nuevo(item);
        }

        // EliminarPasajeros
        public bool EliminarPasajeros(int id)
        {
            Pasajero item = pasajeros.BuscarID(id);
            return pasajeros.Eliminar(item);
        }

        // ActualizarPasajeros
        public bool ActualizarPasajeros(Pasajero item)
        {
            return pasajeros.Actualizar(item);
        }


    }
}
