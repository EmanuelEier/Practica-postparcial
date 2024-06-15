using LibreriaService;
using System.Linq;

namespace LibreriaTest
{
    public class Tests
    {
        Lógica lógica = new Lógica();

        [SetUp]
        public void Setup()
        {
            lógica = new Lógica();
        }

        [Test]
        public void generarNuevaVenta_Ok()
        {
            //ARRENGE
            List<Articulo> misArticulos = new List<Articulo>();
            misArticulos.Add(new Lapicera() { Código = "aaa1", Marca = "Bic", Nombre = "Lapicera", CantStock = 5, PrecioVenta = 300, Colores = (EnumColor)2, TipoTrazo = (EnumTrazo)2 });
            misArticulos.Add(new Lapicera() { Código = "bbb2", Marca = "Bic", Nombre = "Lapicera", CantStock = 3, PrecioVenta = 700, Colores = (EnumColor)2, TipoTrazo = (EnumTrazo)2 });
            misArticulos.Add(new Regla() { Código = "ccc3", Marca = "Pamco", Nombre = "Regla", CantStock = 2, PrecioVenta = 500, TamañoCm = 30 });
            misArticulos.Add(new Cuaderno() { Código = "ddd4", Marca = "1810", Nombre = "Cuadernillo a4", CantStock = 10, PrecioVenta = 200, CantHojas = 70, TipoHoja = (EnumTipoHoja)2 });
            misArticulos.Add(new Cuaderno() { Código = "eee5", Marca = "Rivadavia", Nombre = "Cuaderno", CantStock = 20, PrecioVenta = 300, CantHojas = 80, TipoHoja = (EnumTipoHoja)1 });
            lógica.Articulos = misArticulos;

            List<ArticuloVendido> articulosVendidos = new List<ArticuloVendido>();
        articulosVendidos.Add(new ArticuloVendido()
        {
            Código = "aaa1",
            Cantidad = 2,
        });


            articulosVendidos.Add(new ArticuloVendido()
        {
            Código = "bbb2",
            Cantidad = 4,
        });


            articulosVendidos.Add(new ArticuloVendido()
        {
            Código = "ccc3",
            Cantidad = 1,
        });

            articulosVendidos.Add(new ArticuloVendido()
        {
            Código = "ddd4",
            Cantidad = 6,
        });

            articulosVendidos.Add(new ArticuloVendido()
        {
            Código = "eee5",
            Cantidad = 1,
        });


            //ACT
            var ventasRealizadas = lógica.agregarVenta(45343929, 10, articulosVendidos);


            //ASSERT
            Assert.That(ventasRealizadas.Count, Is.EqualTo(1));
        }

        [Test]
        public void actualizarStock_Ok()
        {
            //ARRENGE
            List<Articulo> misArticulos = new List<Articulo>();
            misArticulos.Add(new Lapicera() { Código = "aaa1", Marca = "Bic", Nombre = "Lapicera", CantStock = 5, PrecioVenta = 300, Colores = (EnumColor)2, TipoTrazo = (EnumTrazo)2 });
            misArticulos.Add(new Lapicera() { Código = "bbb2", Marca = "Bic", Nombre = "Lapicera", CantStock = 3, PrecioVenta = 700, Colores = (EnumColor)2, TipoTrazo = (EnumTrazo)2 });
            misArticulos.Add(new Regla() { Código = "ccc3", Marca = "Pamco", Nombre = "Regla", CantStock = 2, PrecioVenta = 500, TamañoCm = 30 });
            misArticulos.Add(new Cuaderno() { Código = "ddd4", Marca = "1810", Nombre = "Cuadernillo a4", CantStock = 10, PrecioVenta = 200, CantHojas = 70, TipoHoja = (EnumTipoHoja)2 });
            misArticulos.Add(new Cuaderno() { Código = "eee5", Marca = "Rivadavia", Nombre = "Cuaderno", CantStock = 20, PrecioVenta = 300, CantHojas = 80, TipoHoja = (EnumTipoHoja)1 });
            lógica.Articulos = misArticulos;

            //ACT
            var listado = lógica.actualizaciónStockDisponible("aaa1", 10);
         
            //ASSERT
            Assert.That(listado[0].CantStock, Is.EqualTo(15));
         }

        [Test]
        public void filtrarPorTipoArticulo_Ok()
        {
            //ARRENGE
            List<Articulo> misArticulos = new List<Articulo>();
            misArticulos.Add(new Lapicera() { Código = "aaa1", Marca = "Bic", Nombre = "Lapicera", CantStock = 5, PrecioVenta = 300, Colores = (EnumColor)2, TipoTrazo = (EnumTrazo)2 });
            misArticulos.Add(new Lapicera() { Código = "bbb2", Marca = "Bic", Nombre = "Lapicera", CantStock = 3, PrecioVenta = 700, Colores = (EnumColor)2, TipoTrazo = (EnumTrazo)2 });
            misArticulos.Add(new Regla() { Código = "ccc3", Marca = "Pamco", Nombre = "Regla", CantStock = 2, PrecioVenta = 500, TamañoCm = 30 });
            misArticulos.Add(new Cuaderno() { Código = "ddd4", Marca = "1810", Nombre = "Cuadernillo a4", CantStock = 10, PrecioVenta = 200, CantHojas = 70, TipoHoja = (EnumTipoHoja)2 });
            misArticulos.Add(new Cuaderno() { Código = "eee5", Marca = "Rivadavia", Nombre = "Cuaderno", CantStock = 20, PrecioVenta = 300, CantHojas = 80, TipoHoja = (EnumTipoHoja)1 });
            misArticulos.Add(new Regla() { Código = "fff6", Marca = "Sain", Nombre = "Regla", CantStock = 14, PrecioVenta = 500, TamañoCm = 20 });
            misArticulos.Add(new Cuaderno() { Código = "ggg7", Marca = "Rivadavia", Nombre = "Cuaderno", CantStock = 10, PrecioVenta = 300, CantHojas = 60, TipoHoja = (EnumTipoHoja)1 });
            misArticulos.Add(new Cuaderno() { Código = "hhh8", Marca = "Rivadavia", Nombre = "Cuaderno", CantStock = 15, PrecioVenta = 300, CantHojas = 80, TipoHoja = (EnumTipoHoja)2 });

            lógica.Articulos = misArticulos;

            //ACT
            var (listaCuadernos, listaReglas, listaLapiceras) = lógica.devolverArticulosFiltradosPorTipo();
            
            //ASSERT
            Assert.That(listaCuadernos.Any(x => x.GetType() == typeof(Regla)), Is.EqualTo(false));
            Assert.That(listaCuadernos.Any(x => x.GetType() == typeof(Lapicera)), Is.EqualTo(false));
            Assert.That(listaReglas.Any(x => x.GetType() == typeof(Cuaderno)), Is.EqualTo(false));
            Assert.That(listaReglas.Any(x => x.GetType() == typeof(Lapicera)), Is.EqualTo(false));
            Assert.That(listaLapiceras.Any(x => x.GetType() == typeof(Regla)), Is.EqualTo(false));
            Assert.That(listaLapiceras.Any(x => x.GetType() == typeof(Cuaderno)), Is.EqualTo(false));
        }

        [Test]
        public void filtrarPorStockMenorA5()
        {
            //ARRENGE
            List<Articulo> misArticulos = new List<Articulo>();
            misArticulos.Add(new Lapicera() { Código = "aaa1", Marca = "Bic", Nombre = "Lapicera", CantStock = 5, PrecioVenta = 300, Colores = (EnumColor)2, TipoTrazo = (EnumTrazo)2 });
            misArticulos.Add(new Lapicera() { Código = "bbb2", Marca = "Bic", Nombre = "Lapicera", CantStock = 3, PrecioVenta = 700, Colores = (EnumColor)2, TipoTrazo = (EnumTrazo)2 });
            misArticulos.Add(new Regla() { Código = "ccc3", Marca = "Pamco", Nombre = "Regla", CantStock = 2, PrecioVenta = 500, TamañoCm = 30 });
            misArticulos.Add(new Cuaderno() { Código = "ddd4", Marca = "1810", Nombre = "Cuadernillo a4", CantStock = 10, PrecioVenta = 200, CantHojas = 70, TipoHoja = (EnumTipoHoja)2 });
            misArticulos.Add(new Cuaderno() { Código = "eee5", Marca = "Rivadavia", Nombre = "Cuaderno", CantStock = 20, PrecioVenta = 300, CantHojas = 80, TipoHoja = (EnumTipoHoja)1 });
            misArticulos.Add(new Regla() { Código = "fff6", Marca = "Sain", Nombre = "Regla", CantStock = 14, PrecioVenta = 500, TamañoCm = 20 });
            misArticulos.Add(new Cuaderno() { Código = "ggg7", Marca = "Rivadavia", Nombre = "Cuaderno", CantStock = 10, PrecioVenta = 300, CantHojas = 60, TipoHoja = (EnumTipoHoja)1 });
            misArticulos.Add(new Cuaderno() { Código = "hhh8", Marca = "Rivadavia", Nombre = "Cuaderno", CantStock = 4, PrecioVenta = 300, CantHojas = 80, TipoHoja = (EnumTipoHoja)2 });
            lógica.Articulos = misArticulos;

            //ACT
            var articulosStockMenor5 = lógica.consultaArticulosStockMenorA5();

            //ASSERT
            Assert.That(articulosStockMenor5.Count, Is.EqualTo(4));
        }
    }
}