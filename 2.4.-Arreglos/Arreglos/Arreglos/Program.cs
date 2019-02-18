using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string num;
            int[] arreglo = new int[21];

            for (i = 0; i < 21; i++)
            {
                num = Console.ReadLine();
                arreglo[i] = Convert.ToInt32(num);
            }

            for (i = 0; i < 21; i++)
            {
                Console.WriteLine("{0}", arreglo[i]);
            }
            Console.ReadKey();
        }
    }
}
