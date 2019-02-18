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
            Nombre = " ";
            SueldoDiario = 0.0m;
            Edad = 0;
        }
        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value;}
        }
        public decimal SueldoDiario { get; set; }
        public int Edad { get; set; }
        public decimal CalcularSalario(int NumeroDias)
        {
            return SueldoDiario * NumeroDias;
        }
    }
}