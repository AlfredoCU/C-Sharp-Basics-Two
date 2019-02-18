using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    class Program
    {
        static void Main(string[] args)
        {
            clsClientesConContacto Cliente = new clsClientesConContacto(0, "Alfredo Carreón Urbano",
            "Password3w", "78784ALF", 1, "3317548468", "3456645", "alf@gmail.com",
            "Lomas", "3074", "A", "Hierro", "Palacio", "Jalisco", "44740");

            Console.WriteLine("1.-Imprimir a consola.");
            Console.WriteLine("2.-Escribir en archivo.");
            Console.Write("La Opción es: ");
            string opc = Console.ReadLine();
            if (opc == "1")
            {
                clsImpresion Impresion = new clsImpresion();
                Impresion.ImprimeCliente(Cliente);
            }
            else
            {
                intSalidas Archivo = new clsArchivos();
                Archivo.ImprimeCliente(Cliente);
            }
        }
    }
}
