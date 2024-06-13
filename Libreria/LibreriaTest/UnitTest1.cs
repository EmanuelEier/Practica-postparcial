using LibreriaService;
using System.Linq;

namespace LibreriaTest
{
    public class Tests
    {
        Lógica lógica {  get; set; }

        [SetUp]
        public void Setup()
        {
            Lógica lógica = new Lógica();
        }

        [Test]
        public void Test1()
        {
            //ARRENGE
      

            List<ArticuloVendido> articulosVendidos = new List<ArticuloVendido>();
        articulosVendidos.Add(new ArticuloVendido()
        {
            CódigoProducto = "aaa1",
            Cantidad = 2,
        });


            articulosVendidos.Add(new ArticuloVendido()
        {
            CódigoProducto = "bbb2",
            Cantidad = 4,
        });


            articulosVendidos.Add(new ArticuloVendido()
        {
            CódigoProducto = "ccc3",
            Cantidad = 1,
        });

            articulosVendidos.Add(new ArticuloVendido()
        {
            CódigoProducto = "ddd4",
            Cantidad = 6,
        });

            articulosVendidos.Add(new ArticuloVendido()
        {
            CódigoProducto = "eee5",
            Cantidad = 1,
        });


            //ACT
            List<Venta> listadoVentas = lógica.agregarVenta(45343929, 10, articulosVendidos);


            //ASSERT
            Assert.That(listadoVentas.Count, Is.EqualTo(1));
        }
    }
}