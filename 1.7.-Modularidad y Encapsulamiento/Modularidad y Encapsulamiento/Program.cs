using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos_y_Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            clsEmpleados empleado = new clsEmpleados();
            empleado.Edad = 19;
            empleado.Nombre = "Alfredo Carreón Urbano.";
            empleado.SueldoDiario = 1021.5m;

            decimal Total;
            Total = empleado.CalcularSalario(30);

            Console.WriteLine("-El salario diario del empleado: " + empleado.Nombre);
            Console.WriteLine("-Es: " + Total.ToString("C"));
            Console.ReadKey();
        }
    }
}