using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversiones_de_tipo
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            decimal x = 12.2m; // m es un modificador.
            bool bandera = true;
            string cadena = "12345"; //string.Empty;
            DateTime fecha = DateTime.MinValue;

            x = i; // conversión decimal a entero.
            i = (int)x; //conversión de entero a decimal.
            i = Convert.ToInt32(x); //Conversión utilizando "Convert" 
            i = Convert.ToInt32(bandera); //Conversión de bandera a entero. 
            i = Convert.ToInt32(cadena); //Siempre y cuando sea: string cadena = "12345"; 
            //Sino saldra erro en la ejecución.
    
            Console.WriteLine("El valor de i es: {0}", i);
            Console.WriteLine("El valor de d es: {0:C}", x);
            Console.WriteLine("El valor de la bandera es: " + bandera.ToString());
            Console.WriteLine("El valor de la cadena es: " + cadena);
            Console.WriteLine("El valor de la fecha es: "+ fecha.ToShortDateString());
            Console.ReadKey();
        }
    }
}
