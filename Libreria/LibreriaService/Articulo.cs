using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaService
{
    public class Articulo
    {
        public string Código { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public int CantStock { get; set; }
        public int PrecioVenta { get; set; }

    }
}
