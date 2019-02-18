using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashMapProyect
{
    // Colocar una clave unica a un valor que lo identifique.
    class clsMuestraHashTable
    {
        Hashtable Tabla;

        public clsMuestraHashTable()
        {
            Tabla = new Hashtable();
        }

        public void AgregarDatos()
        {
            Tabla.Add("A001", "Producto 1");
            Tabla.Add("ACU2", "Producto 2");
            Tabla.Add("ABV3", "Producto 3");
            Tabla.Add("ART4", "Producto 4");
            Tabla.Add("AFG5", "Producto 5");
        }

        public void ImprimirDatos()
        {
            Console.Write("Protuctos Existentes {0}, dame la clave del producto: ", Tabla.Count);
            string clave = Console.ReadLine();
            if (Tabla[clave] == null)
            {
                Console.WriteLine("El producto no exise.");
            }
            else
            {
                Console.Write("El producto encontrado es: " + Tabla[clave]);
            }
            Console.ReadKey();
        }

        public void EliminarProducto(string clave)
        {
            Tabla.Remove(clave);
        }
    }
}
