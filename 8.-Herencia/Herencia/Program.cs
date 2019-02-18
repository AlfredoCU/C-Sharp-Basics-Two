using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            clsClientesVentas Clientes;
            Clientes = new clsClientesVentas();
            Clientes.IdCliente = 123;
            Clientes.Apellido = "Carreón Urbano";
            Clientes.Nombres = "Alfredo";
            Clientes.RFC = "12540";
            Clientes.Direccion = "Marcas Lora";
            Clientes.Colonia = "Benito Juarez";
            Clientes.Municipio = "Zapopan";
            Clientes.EsCredito = true;

            Console.WriteLine(Clientes.Apellido + " " + Clientes.Nombres);
            Console.WriteLine(Clientes.Direccion + " " + Clientes.Colonia + " " + Clientes.Municipio);
            Console.WriteLine(Clientes.RFC);

            if (Clientes.EsCredito)
                Console.WriteLine("El cliente tiene credito.");
            else
                Console.WriteLine("El cliente no tiene credito.");
            Console.ReadKey();
        }
    }
}
