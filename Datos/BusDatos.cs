using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Datos
{
    public class BusDatos : IDatos<Bus>
    {
        servicioEntities contexto;

        public BusDatos()
        {
            contexto = new servicioEntities();
        }

        public bool Actualizar(Bus item)
        {
            if(item != null)
            {

               contexto.Entry(item).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Eliminar(Bus item)
        {
            if(item != null)
            {
                contexto.Buses.Remove(item);
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public Bus BuscarID(int id)
        {

           return contexto.Buses.Where(b => b.ID_Bus == id).FirstOrDefault();
        }

        public List<Bus> Listar()
        {
            return contexto.Buses.ToList();
        }

        public bool Nuevo(Bus item)
        {
            contexto.Buses.Add(item);
            return contexto.SaveChanges() > 0;
        }
    }
}
