using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Abstractas
{
    class Program
    {
        static void Main(string[] args)
        {
            clsClientesBase Cliente = new clsClientesBase(0,"Alfredo","pass542",
           "1546A",1,"Alfredo Carreón Urbano.");

            Console.WriteLine(Cliente.Clave + " " + Cliente.Nombre);
            Console.WriteLine(Cliente.TipoRegimen);
            Console.WriteLine(Cliente.RFC);
            Console.ReadKey();
        }
    }
}
