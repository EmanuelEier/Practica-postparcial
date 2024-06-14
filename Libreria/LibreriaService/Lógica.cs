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
            var listaCorroborando = articulosVendidos.Select(x => x.CódigoProducto).ToList();
            foreach (Articulo art in listaCorroborando)
            {
                if (art.Código == ) { }
            }

            Venta venta = new Venta()
            {
                DNICliente = DNI,
                Descuento = descuento,
                ArticulosVendidos = articulosVendidos,
                ImporteTotal = calcularImporteTotal(Articulos),
                Fecha = DateTime.Now,
            };

            Ventas.Add(venta);
            return Ventas;
        }

        public double calcularImporteTotal(List<Articulo> articulosVendidos)
        {
            int acum = 0;
            foreach (var producto in articulosVendidos)
            {
                acum += producto.PrecioVenta;
            }

            return acum;
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

        
        

    }


}