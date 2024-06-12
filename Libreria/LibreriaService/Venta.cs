using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaService
{
    public class Venta
    {
        public int DNICliente { get; set; }
        public int Descuento { get; set; }
        public List<Articulo> ArticulosVendidos { get; set; }
        public double ImporteTotal { get; set; }
        public DateTime Fecha { get; set; }

    }
}
