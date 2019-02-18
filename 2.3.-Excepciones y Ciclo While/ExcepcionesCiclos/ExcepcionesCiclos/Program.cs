using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesCiclos
{
    class Program
    {
        static void Main(string[] args)
        {
            clsClientesConContacto Datos = new clsClientesConContacto(0, "Alfredo Carreón Urbano",
            "Password3w", "78784ALF", 1, "3317548468", "3456645", "alf@gmail.com",
            "Lomas", "3074", "A", "Hierro", "Palacio", "Jalisco", "44740");

            clsDirecciones DatosD = new clsDirecciones("Lomas", "Hierro", "Palacio");

            string opc;

            do
            {
                Console.WriteLine("*******ABC Clientes*******\n");
                Console.WriteLine("1.-Imprimir cliente en consola.");
                Console.WriteLine("2.-Imprimir dirección en consola.");
                Console.WriteLine("3.-Escribir cliente en archivo.");
                Console.WriteLine("4.-Escribir dirección en archivo.");
                Console.WriteLine("5.-Salir \n");
                Console.Write("La Opción es: ");
                opc = Console.ReadLine();

                if (opc == "1")
                {
                    clsImpresion Impresion = new clsImpresion();
                    Impresion.ImprimeCliente(Datos);
                }
                else if (opc == "2")
                {
                    clsImpresion Impresion = new clsImpresion();
                    Impresion.ImprimeDireccion(DatosD);
                }
                else if (opc == "3")
                {
                    intSalidas Archivo = new clsArchivos();
                    try
                    {
                        Archivo.ImprimeCliente(Datos);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("-Ocurrio un error: " + e.Message);
                        Console.ReadKey();
                    }
                }
                else if (opc == "4")
                {
                    intSalidas Archivo = new clsArchivos();
                    try
                    {
                        Archivo.ImprimeDireccion(DatosD);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("-Ocurrio un error: " + e.Message);
                        Console.ReadKey();
                    }
                }
                else if(opc == "5")
                {
                    Console.WriteLine("-Salir del sistema.");
                }
                else
                {
                    Console.WriteLine("-Opción no valida!");
                }
            } while (opc != "5");
        }
    }
}
