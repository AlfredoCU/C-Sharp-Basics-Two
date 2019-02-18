using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashMapProyect
{
    class Program
    {
        static void Main(string[] args)
        {
            clsMuestraHashTable Elementos = new clsMuestraHashTable();
            Elementos.AgregarDatos();
            Elementos.ImprimirDatos();
            Elementos.EliminarProducto("A001");
            Elementos.ImprimirDatos();
        }
    }
}
