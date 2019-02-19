using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    class Program
    {
        static void Main(string[] args)
        {
            List<clsProductosBase> productos = new List<clsProductosBase>();
            clsArchivoProductos arch = new clsArchivoProductos();
            arch.avance += main_avance;
            arch.ObtenProductos(productos);
            Console.ReadKey();
            foreach (var item in productos)
            {
                Console.WriteLine(item.Descripcion);
            }
            Console.ReadKey();
        }

        private static void main_avance(string valor)
        {
            Console.WriteLine(valor);
        }
    }
}
