using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;


namespace Datos
{
    public class TicketsDatos : IDatos<Tickets>
    {
        servicioEntities contexto;

        public TicketsDatos()
        {
            contexto = new servicioEntities();
        }

        public bool Actualizar(Tickets item)
        {
            if(item != null)
            {
                contexto.Entry(item).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public Tickets BuscarID(int id)
        {
            return contexto.Tickets.Where(t => t.ID_Ticket == id).FirstOrDefault();
        }

        public bool Eliminar(Tickets item)
        {
            if (item != null)
            {
                contexto.Tickets.Remove(item);
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Tickets> Listar()
        {
            return contexto.Tickets.ToList();
        }

        public bool Nuevo(Tickets item)
        {
            contexto.Tickets.Add(item);
            return contexto.SaveChanges() > 0;
        }
    }
}
