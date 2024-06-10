using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;


namespace Datos
{
    public class PasajerosDatos : IDatos<Pasajeros>
    {
        servicioEntities contexto;

        public PasajerosDatos()
        {
            contexto = new servicioEntities();
        }

        public bool Actualizar(Pasajeros item)
        {
            if(item != null)
            {
                contexto.Entry(item).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public Pasajeros BuscarID(int id)
        {
            return contexto.Pasajeros.Where(p => p.ID_Pasajero == id).FirstOrDefault();
        }

        public bool Eliminar(Pasajeros item)
        {
            if (item != null)
            {
                contexto.Pasajeros.Remove(item);
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Pasajeros> Listar()
        {
            return contexto.Pasajeros.ToList();
        }

        public bool Nuevo(Pasajeros item)
        {
            contexto.Pasajeros.Add(item);
            return contexto.SaveChanges() > 0;
        }
    }
}
