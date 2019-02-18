using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class clsImpresion
    {
        public void ImprimeCliente(clsAbsClientes Cliente)
        {
            Console.WriteLine(Cliente.Clave + " " + Cliente.Nombre);
            Console.WriteLine(Cliente.TipoRegimen);
            Console.WriteLine(Cliente.RFC);
            Console.ReadKey();
        }
    }
}
