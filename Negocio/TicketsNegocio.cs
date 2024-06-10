using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Datos;

namespace Negocio
{
    public class TicketsNegocio
    {
        TicketsDatos tickets;

        public TicketsNegocio()
        {
            tickets = new TicketsDatos();
        }

        // all
        public List<Tickets> All()
        {
            return tickets.Listar();
        }

        // ByID
        public Tickets ByID(int id)
        {
            return tickets.Listar().Where(x => x.ID_Ticket == id).FirstOrDefault();
        }

        // insertarTickets
        public bool InsertarTickets(Tickets item)
        {
            return tickets.Nuevo(item);
        }

        // EliminarTickets
        public bool EliminarTickets(Tickets item)
        {
            return tickets.Eliminar(item);
        }

        // ActualizarTickets
        public bool ActualizarTickets(Tickets item)
        {
            return tickets.Actualizar(item);
        }
    }
}
