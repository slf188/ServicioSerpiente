using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Datos
{
    public class RutasDatos : IDatos<Ruta>
    {
        servicioEntities contexto;

        public RutasDatos()
        {
            contexto = new servicioEntities();
        }

        public bool Actualizar(Ruta item)
        {
            if(item != null)
            {
                contexto.Entry(item).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public Ruta BuscarID(int id)
        {

            return contexto.Rutas.Where(r => r.ID_Ruta == id).FirstOrDefault();
        }

        public bool Eliminar(Ruta item)
        {
            if (item != null)
            {
                contexto.Rutas.Remove(item);
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Ruta> Listar()
        {
            return contexto.Rutas.ToList();
        }

        public bool Nuevo(Ruta item)
        {
            contexto.Rutas.Add(item);
            return contexto.SaveChanges() > 0;
        }
    }
}
