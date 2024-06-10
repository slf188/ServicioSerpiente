using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;


namespace Datos
{
    public class BusesDatos : IDatos<Buses>
    {
        servicioEntities contexto;

        public BusesDatos()
        {
            contexto = new servicioEntities();
        }

        public bool Actualizar(Buses item)
        {
            if(item != null)
            {

               contexto.Entry(item).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Eliminar(Buses item)
        {
            if(item != null)
            {
                contexto.Buses.Remove(item);
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public Buses BuscarID(int id)
        {

           return contexto.Buses.Where(b => b.ID_Bus == id).FirstOrDefault();
        }

        public List<Buses> Listar()
        {
            return contexto.Buses.ToList();
        }

        public bool Nuevo(Buses item)
        {
            contexto.Buses.Add(item);
            return contexto.SaveChanges() > 0;
        }
    }
}
