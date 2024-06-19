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

        public ConductoresNegocio()
        {
            conductores = new ConductoresDatos();
        }

        // All
        public List<Conductore> All()
        {

            return conductores.Listar();
        }

        // ById
        public Conductore ByID(int id)
        {
            return conductores.Listar().Where(x => x.ID_Conductor == id).FirstOrDefault();
        }

        // InsertarConductores
        public bool InsertarConductores(Conductore item)
        {
            return conductores.Nuevo(item);
        }

        // EliminarConductores
        public bool EliminarConductores(int id)
        {
            Conductore item = conductores.BuscarID(id);
            return conductores.Eliminar(item);
        }

        // ActualizarConductores
        public bool ActualizarConductores(Conductore item)
        {
            return conductores.Actualizar(item);
        }
    }
}
