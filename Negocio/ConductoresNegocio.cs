using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Datos;

namespace Negocio
{
    public class ConductoresNegocio
    {
        ConductoresDatos conductores;

        ConductoresNegocio()
        {
            conductores = new ConductoresDatos();
        }

        // All
        public List<Conductores> All()
        {

           return conductores.Listar();
        }

        // ById
        public Conductores ById(int id)
        {
            return conductores.Listar().Where(x => x.ID_Conductor == id).FirstOrDefault();
        }

        // InsertarConductores
        public bool InsertarConductores(Conductores item)
        {
            return conductores.Nuevo(item);
        }

        // EliminarConductores
        public bool EliminarConductores(Conductores item)
        {
            return conductores.Eliminar(item);
        }

        // ActualizarConductores
        public bool ActualizarConductores(Conductores item)
        {
            return conductores.Actualizar(item);
        }


    }
}
