using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;


namespace Datos
{
    public class ConductoresDatos : IDatos<Conductore>
    {
        servicioEntities contexto;
         
        public ConductoresDatos()
        {
            contexto = new servicioEntities();
        }

        public bool Actualizar(Conductore item)
        {
            if(item != null)
            {
                contexto.Entry(item).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public Conductore BuscarID(int id)
        {

            return contexto.Conductores.Where(c => c.ID_Conductor == id).FirstOrDefault();
        }

        public bool Eliminar(Conductore item)
        {
            if (item != null)
            {
                contexto.Conductores.Remove(item);
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Conductore> Listar()
        {
            return contexto.Conductores.ToList();
        }

        public bool Nuevo(Conductore item)
        {
            contexto.Conductores.Add(item);
            return contexto.SaveChanges() > 0;
        }
    }
}
