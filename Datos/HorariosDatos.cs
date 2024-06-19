using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;


namespace Datos
{
    public class HorariosDatos : IDatos<Horario>
    {
        servicioEntities contexto;

        public HorariosDatos()
        {
            contexto = new servicioEntities();
        }

        public bool Actualizar(Horario item)
        {
            if(item != null)
            {
                contexto.Entry(item).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public Horario BuscarID(int id)
        {
            return contexto.Horarios.Where(h => h.ID_Horario == id).FirstOrDefault();
        }

        public bool Eliminar(Horario item)
        {
            if (item != null)
            {
                contexto.Horarios.Remove(item);
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Horario> Listar()
        {
            return contexto.Horarios.ToList();
        }

        public bool Nuevo(Horario item)
        {
            contexto.Horarios.Add(item);
            return contexto.SaveChanges() > 0;
        }
    }
}
