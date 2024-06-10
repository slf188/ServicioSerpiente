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
        public List<Pasajeros> All()
        {
            return pasajeros.Listar();
        }

        // ById
        public Pasajeros ById(int id)
        {
            return pasajeros.Listar().Where(x => x.ID_Pasajero == id).FirstOrDefault();
        }

        // InsertarPasajeros
        public bool InsertarPasajeros(Pasajeros item)
        {
            return pasajeros.Nuevo(item);
        }

        // EliminarPasajeros
        public bool EliminarPasajeros(Pasajeros item)
        {
            return pasajeros.Eliminar(item);
        }

        // ActualizarPasajeros
        public bool ActualizarPasajeros(Pasajeros item)
        {
            return pasajeros.Actualizar(item);
        }


    }
}
