using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{
    class Program
    {
        static void Main(string[] args)
        {
            string opc, datos;
            List<clsClientesBase> Clientes = new List<clsClientesBase>();

            do
            {
                Console.WriteLine("*******Genéricos*******\n");
                Console.WriteLine("1) Agregar a la lista.");
                Console.WriteLine("2) Quitar a la lista.");
                Console.WriteLine("3) Imprimir la lista.");
                Console.WriteLine("4) Salir del sistema.\n");
                Console.Write("-Opción: ");
                opc = Console.ReadLine();

                switch (opc)
                {
                    case "1":
                        Console.Write("Ingresa el nombre: ");
                        datos = Console.ReadLine();
                        clsClientesBase Cliente = new clsClientesBase();
                        Cliente.Id = Clientes.Count + 1;
                        Cliente.Nombre = datos;
                        Clientes.Add(Cliente);
                        break;
                    case "2":
                        Console.Write("Eliminar por index: ");
                        datos = Console.ReadLine();
                        Clientes.RemoveAt(Convert.ToInt32(datos));
                        break;
                    case "3":
                        foreach (clsClientesBase item in Clientes)
                        {
                            Console.WriteLine("Los datos del cliente son: ");
                            Console.WriteLine(item.Id.ToString() + " " + item.Nombre);
                        }
                        break;
                    case "4":
                        Console.WriteLine("Salir del sistema.");
                        break;
                    default:
                        Console.WriteLine("¡Opción invalida!");
                        break;
                }
            } while (opc != "4");
        }
    }
}
