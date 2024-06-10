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
        public List<Rutas> All()
        {
            return rutas.Listar();
        }

        // ById
        public Rutas ById(int id)
        {
            return rutas.Listar().Where(x => x.ID_Ruta == id).FirstOrDefault();
        }

        // InsertarRutas
        public bool InsertarRutas(Rutas item)
        {
            return rutas.Nuevo(item);
        }

        // EliminarRutas
        public bool EliminarRutas(Rutas item)
        {
            return rutas.Eliminar(item);
        }

        // ActualizarRutas
        public bool ActualizarRutas(Rutas item)
        {
            return rutas.Actualizar(item);
        }
    }
}
