using LibreriaService;
using System.Linq;

namespace LibreriaTest
{
    public class Tests
    {
        L�gica l�gica = new L�gica();

        [SetUp]
        public void Setup()
        {
            l�gica = new L�gica();
        }

        [Test]
        public void generarNuevaVenta_Ok()
        {
            //ARRENGE
            List<Articulo> misArticulos = new List<Articulo>();
            misArticulos.Add(new Lapicera() { C�digo = "aaa1", Marca = "Bic", Nombre = "Lapicera", CantStock = 5, PrecioVenta = 300, Colores = (EnumColor)2, TipoTrazo = (EnumTrazo)2 });
            misArticulos.Add(new Lapicera() { C�digo = "bbb2", Marca = "Bic", Nombre = "Lapicera", CantStock = 3, PrecioVenta = 700, Colores = (EnumColor)2, TipoTrazo = (EnumTrazo)2 });
            misArticulos.Add(new Regla() { C�digo = "ccc3", Marca = "Pamco", Nombre = "Regla", CantStock = 2, PrecioVenta = 500, Tama�oCm = 30 });
            misArticulos.Add(new Cuaderno() { C�digo = "ddd4", Marca = "1810", Nombre = "Cuadernillo a4", CantStock = 10, PrecioVenta = 200, CantHojas = 70, TipoHoja = (EnumTipoHoja)2 });
            misArticulos.Add(new Cuaderno() { C�digo = "eee5", Marca = "Rivadavia", Nombre = "Cuaderno", CantStock = 20, PrecioVenta = 300, CantHojas = 80, TipoHoja = (EnumTipoHoja)1 });
            l�gica.Articulos = misArticulos;

            List<ArticuloVendido> articulosVendidos = new List<ArticuloVendido>();
        articulosVendidos.Add(new ArticuloVendido()
        {
            C�digo = "aaa1",
            Cantidad = 2,
        });


            articulosVendidos.Add(new ArticuloVendido()
        {
            C�digo = "bbb2",
            Cantidad = 4,
        });


            articulosVendidos.Add(new ArticuloVendido()
        {
            C�digo = "ccc3",
            Cantidad = 1,
        });

            articulosVendidos.Add(new ArticuloVendido()
        {
            C�digo = "ddd4",
            Cantidad = 6,
        });

            articulosVendidos.Add(new ArticuloVendido()
        {
            C�digo = "eee5",
            Cantidad = 1,
        });


            //ACT
            var ventasRealizadas = l�gica.agregarVenta(45343929, 10, articulosVendidos);


            //ASSERT
            Assert.That(ventasRealizadas.Count, Is.EqualTo(1));
        }

        [Test]
        public void actualizarStock_Ok()
        {
            //ARRENGE
            List<Articulo> misArticulos = new List<Articulo>();
            misArticulos.Add(new Lapicera() { C�digo = "aaa1", Marca = "Bic", Nombre = "Lapicera", CantStock = 5, PrecioVenta = 300, Colores = (EnumColor)2, TipoTrazo = (EnumTrazo)2 });
            misArticulos.Add(new Lapicera() { C�digo = "bbb2", Marca = "Bic", Nombre = "Lapicera", CantStock = 3, PrecioVenta = 700, Colores = (EnumColor)2, TipoTrazo = (EnumTrazo)2 });
            misArticulos.Add(new Regla() { C�digo = "ccc3", Marca = "Pamco", Nombre = "Regla", CantStock = 2, PrecioVenta = 500, Tama�oCm = 30 });
            misArticulos.Add(new Cuaderno() { C�digo = "ddd4", Marca = "1810", Nombre = "Cuadernillo a4", CantStock = 10, PrecioVenta = 200, CantHojas = 70, TipoHoja = (EnumTipoHoja)2 });
            misArticulos.Add(new Cuaderno() { C�digo = "eee5", Marca = "Rivadavia", Nombre = "Cuaderno", CantStock = 20, PrecioVenta = 300, CantHojas = 80, TipoHoja = (EnumTipoHoja)1 });
            l�gica.Articulos = misArticulos;

            //ACT
            var listado = l�gica.actualizaci�nStockDisponible("aaa1", 10);
         
            //ASSERT
            Assert.That(listado[0].CantStock, Is.EqualTo(15));
         }

        public void filtrarPorTipoArticulo()
        {
            //ARRENGE
            List<Articulo> misArticulos = new List<Articulo>();
            misArticulos.Add(new Lapicera() { C�digo = "aaa1", Marca = "Bic", Nombre = "Lapicera", CantStock = 5, PrecioVenta = 300, Colores = (EnumColor)2, TipoTrazo = (EnumTrazo)2 });
            misArticulos.Add(new Lapicera() { C�digo = "bbb2", Marca = "Bic", Nombre = "Lapicera", CantStock = 3, PrecioVenta = 700, Colores = (EnumColor)2, TipoTrazo = (EnumTrazo)2 });
            misArticulos.Add(new Regla() { C�digo = "ccc3", Marca = "Pamco", Nombre = "Regla", CantStock = 2, PrecioVenta = 500, Tama�oCm = 30 });
            misArticulos.Add(new Cuaderno() { C�digo = "ddd4", Marca = "1810", Nombre = "Cuadernillo a4", CantStock = 10, PrecioVenta = 200, CantHojas = 70, TipoHoja = (EnumTipoHoja)2 });
            misArticulos.Add(new Cuaderno() { C�digo = "eee5", Marca = "Rivadavia", Nombre = "Cuaderno", CantStock = 20, PrecioVenta = 300, CantHojas = 80, TipoHoja = (EnumTipoHoja)1 });
            l�gica.Articulos = misArticulos;

            //ACT
            l�gica.devolverArticulosFiltradosPorTipo();
        }
    }
}