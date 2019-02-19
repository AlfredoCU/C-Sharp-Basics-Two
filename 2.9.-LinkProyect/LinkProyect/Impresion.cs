using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkProyect
{
    public static class Impresion
    {
        public static void ImprimeProductos(List<clsProductosInventario> productos)
        {
            foreach (var producto in productos)
            {
                Console.WriteLine("{0} Código: {1} Des: {2} Precio: {3} Costo: {4} Existencia {5}",
                                    producto.IdProducto, producto.Clave, producto.Descripcion,
                                    producto.PrecioPublico, producto.Costo, producto.Existencias);
            }
            Console.WriteLine("----------------------------------");
        }

        public static void ImprimeTiempo(long tiempo)
        {
            Console.WriteLine("El tiempo transcurrido en tics de reloj es de: {0}", tiempo);
        }

        public static void EsperaTecla()
        {
            Console.ReadKey();
        }
    }
}
