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
        public List<Ticket> All()
        {
            return tickets.Listar();
        }

        // ByID
        public Ticket ByID(int id)
        {
            return tickets.Listar().Where(x => x.ID_Ticket == id).FirstOrDefault();
        }

        // insertarTickets
        public bool InsertarTickets(Ticket item)
        {
            return tickets.Nuevo(item);
        }

        // EliminarTickets
        public bool EliminarTickets(int id)
        {
            Ticket ticket = tickets.BuscarID(id);
            return tickets.Eliminar(ticket);
        }

        // ActualizarTickets
        public bool ActualizarTickets(Ticket item)
        {
            return tickets.Actualizar(item);
        }
    }
}
