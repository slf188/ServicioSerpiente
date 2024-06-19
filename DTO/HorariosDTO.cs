using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HorariosDTO
    {
        public int ID_Horario { get; set; }
        public int ID_Ruta { get; set; }
        public int ID_Bus { get; set; }
        public int ID_Conductor { get; set; }
        public string Dia_Semana { get; set; }
        public TimeSpan Hora_Salida { get; set; }
        public TimeSpan Hora_Llegada { get; set; }
    }
}
