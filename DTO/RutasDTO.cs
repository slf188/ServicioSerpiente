using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RutasDTO
    {
        public int ID_Ruta { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public decimal Distancia { get; set; }
        public TimeSpan Duracion_Estimada { get; set; }
        public string Foto { get; set; }
    }
}
