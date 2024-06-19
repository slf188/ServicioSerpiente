using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Datos;

namespace Negocio
{
    public class RutasNegocio
    {
        RutasDatos rutas;

        public RutasNegocio()
        {
            rutas = new RutasDatos();
        }

        // All
        public List<Ruta> All()
        {
            return rutas.Listar();
        }

        // ById
        public Ruta ByID(int id)
        {
            return rutas.Listar().Where(x => x.ID_Ruta == id).FirstOrDefault();
        }

        // InsertarRutas
        public bool InsertarRutas(Ruta item)
        {
            return rutas.Nuevo(item);
        }

        // EliminarRutas
        public bool EliminarRutas(int id)
        {
            Ruta item = rutas.BuscarID(id);
            return rutas.Eliminar(item);
        }

        // ActualizarRutas
        public bool ActualizarRutas(Ruta item)
        {
            return rutas.Actualizar(item);
        }
    }
}
