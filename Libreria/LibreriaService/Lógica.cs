using System.Reflection.Metadata.Ecma335;

namespace LibreriaService
{
    public class Lógica
    {
        public List<Articulo> Articulos { get; set; }
        public List<Venta> Ventas { get; set; }
        public List<ArticuloVendido> articulosVendidos { get; set; }

        public Lógica()
        {
            Articulos = new List<Articulo>();
            Ventas = new List<Venta>();
        }



        public List<Venta> agregarVenta(int DNI, int descuento, List<ArticuloVendido> articulosVendidos)
        {
            int stockDisponible = 0;
            foreach (ArticuloVendido art in articulosVendidos)
            {
                var articuloConsulta = Articulos.Find(x => x.Código == art.Código);
                if (art.Cantidad >= articuloConsulta.CantStock) { 
                    art.Cantidad = articuloConsulta.CantStock;
                }                                  
            }

            Venta venta = new Venta()
            {
                DNICliente = DNI,
                Descuento = descuento,
                ArticulosVendidos = articulosVendidos,
                ImporteTotal = calcularImporteTotal(articulosVendidos, descuento),
                Fecha = DateTime.Now,
            };

            Ventas.Add(venta);
            return Ventas;
        }

        public double calcularImporteTotal(List<ArticuloVendido> articulosVendidos, int descuento)
        {
            double importeTotal = 0;
            foreach (var producto in articulosVendidos)
            {
                int indice = Articulos.FindIndex(x => x.Código == producto.Código);
                importeTotal += (Articulos[indice].PrecioVenta) * (producto.Cantidad);
            }

            if (descuento != 0) {
               double desc = descuento * (0.01);
                importeTotal = importeTotal * (1 - desc);
            }

            return importeTotal;
        }

        public string obtenerDetalles(string códigoArticulo)
        { string result = string.Empty;
            int indice = Articulos.FindIndex(x => x.Código == códigoArticulo);

            if (Articulos[indice] is Cuaderno cuaderno)
            {
                result = "cuaderno";
            } else if (Articulos[indice] is Lapicera lapicera)
            {
                result = "lapicera";
            } else
            {
                result = "regla";
            }

            return "- Tipo de producto:" + result
                  + "- Nombre:" + Articulos[indice].Nombre
                  + "- Marca: " + Articulos[indice].Marca
                  + "- Precio venta: " + Articulos[indice].PrecioVenta
                  + "- Stock disponible: " + Articulos[indice].CantStock;
        }
    
        public List<Articulo> actualizaciónStockDisponible(string códigoArtículo, int cantidadParaAgregar)
        {
            int indice = Articulos.FindIndex(x => x.Código == códigoArtículo);
            Articulos[indice].CantStock += cantidadParaAgregar;

        return Articulos;
    }

      public List<Articulo> consultaArticulosStockMenorA5()
        { 
           var articulosStockMenor5 = (List<Articulo>)Articulos.Where(x => x.CantStock < 5); //VER QUE PUEDO HACER ACÁ. SI NO SALE METEMOS UN IF DENTRO DE FOREACH

            return articulosStockMenor5;
        } 

        public (List<Articulo>, List<Articulo>, List<Articulo>s) devolverArticulosFiltradosPorTipo()
        {   List<Articulo> cuadernosFiltrados = new List<Articulo>();
            List<Articulo> reglasFiltradas = new List<Articulo>();
            List<Articulo> lapicerasFiltradas = new List<Articulo>();

            foreach (Articulo articulo in Articulos) {
            if (articulo.GetType() == typeof(Cuaderno))
                {
                    cuadernosFiltrados.Add(articulo);
                }
            else if (articulo.GetType() == typeof(Regla))
                {
                    reglasFiltradas.Add(articulo);
                } else
                {
                    lapicerasFiltradas.Add(articulo);
                }
            }

            return (cuadernosFiltrados, reglasFiltradas, lapicerasFiltradas);
        }

        
        

    }


}