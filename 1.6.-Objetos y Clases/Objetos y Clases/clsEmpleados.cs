using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos_y_Clases
{
    public class clsEmpleados
    {
        public clsEmpleados()
        {
            nombre = " ";
            sueldoDiario = 0.0m;
            edad = 0;
        }
        public string nombre;
        public decimal sueldoDiario;
        public int edad;
        public decimal calcularSalario(int numeroDias)
        {
            return sueldoDiario * numeroDias;
        }
    }
}
