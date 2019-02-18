using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListProyect
{
    class clsArrayList
    {
        ArrayList Lista;

        public clsArrayList()
        {
            Lista = new ArrayList();
        }

        public void CapturarDatos()
        {
            string dato;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Escriba el Dato {0}: ", i + 1);
                dato = Console.ReadLine();
                Lista.Add(dato);
            }
        }

        public void ImprimeDatos()
        {
            foreach (var item in Lista)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}
