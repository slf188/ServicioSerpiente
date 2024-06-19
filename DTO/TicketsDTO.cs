using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TicketsDTO
    {
        public int ID_Ticket { get; set; }
        public int ID_Reserva { get; set; }
        public decimal Precio { get; set; }
        public string Estado_Pago { get; set; }
    }
}
