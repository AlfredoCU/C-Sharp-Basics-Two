using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreglosMultidimensionales
{
    class clsMatrices
    {
        private int[,] Matriz;

        public clsMatrices()
        {
            Matriz = new int[3, 3];
        }

        public void InicializaMatriz()
        {
            Console.WriteLine("*******Arreglos Muntidimensionales*******\n");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Matriz[i, j] = 1;
                }
            }
        }
        public void ImprimeMatriz()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                   Console.Write(" {0} ", Matriz[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
