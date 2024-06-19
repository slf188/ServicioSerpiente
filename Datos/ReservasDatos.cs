using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Datos
{
    public class ReservasDatos : IDatos<Reserva>
    {
        servicioEntities contexto;

        public ReservasDatos()
        {
            contexto = new servicioEntities();
        }

        public bool Actualizar(Reserva item)
        {
            if(item != null)
            {
                contexto.Entry(item).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public Reserva BuscarID(int id)
        {
            return contexto.Reservas.Where(r => r.ID_Reserva == id).FirstOrDefault();
        }

        public bool Eliminar(Reserva item)
        {
            if(item != null)
            {
                contexto.Reservas.Remove(item);
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Reserva> Listar()
        {
            return contexto.Reservas.ToList();
        }

        public bool Nuevo(Reserva item)
        {
            contexto.Reservas.Add(item);
            return contexto.SaveChanges() > 0;
        }
    }
}
