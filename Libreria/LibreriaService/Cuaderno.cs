using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaService
{
    public class Cuaderno : Articulo
    {
        public int CantHojas { get; set; }
        public EnumTipoHoja TipoHoja { get; set; }
    }
}
