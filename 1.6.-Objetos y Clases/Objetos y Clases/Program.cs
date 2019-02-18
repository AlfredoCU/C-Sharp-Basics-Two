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
            clsEmpleados empleado;
            empleado = new clsEmpleados();
            empleado.edad = 19;
            empleado.nombre = "Alfredo Carreón Urbano.";
            empleado.sueldoDiario = 21.5m;

            decimal total;
            total = empleado.calcularSalario(30);

            Console.WriteLine("-El salario diario del empleado: " + empleado.nombre);
            Console.WriteLine("-Es: " + total.ToString("C"));
            Console.ReadKey();
        }
    }
}
