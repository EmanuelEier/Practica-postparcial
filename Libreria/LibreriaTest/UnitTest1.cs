using LibreriaService;
using System.Linq;

namespace LibreriaTest
{
    public class Tests
    {
        L�gica l�gica {  get; set; }

        [SetUp]
        public void Setup()
        {
            L�gica l�gica = new L�gica();
        }

        [Test]
        public void Test1()
        {
            //ARRENGE
      

            List<ArticuloVendido> articulosVendidos = new List<ArticuloVendido>();
        articulosVendidos.Add(new ArticuloVendido()
        {
            C�digoProducto = "aaa1",
            Cantidad = 2,
        });


            articulosVendidos.Add(new ArticuloVendido()
        {
            C�digoProducto = "bbb2",
            Cantidad = 4,
        });


            articulosVendidos.Add(new ArticuloVendido()
        {
            C�digoProducto = "ccc3",
            Cantidad = 1,
        });

            articulosVendidos.Add(new ArticuloVendido()
        {
            C�digoProducto = "ddd4",
            Cantidad = 6,
        });

            articulosVendidos.Add(new ArticuloVendido()
        {
            C�digoProducto = "eee5",
            Cantidad = 1,
        });


            //ACT
            List<Venta> listadoVentas = l�gica.agregarVenta(45343929, 10, articulosVendidos);


            //ASSERT
            Assert.That(listadoVentas.Count, Is.EqualTo(1));
        }
    }
}