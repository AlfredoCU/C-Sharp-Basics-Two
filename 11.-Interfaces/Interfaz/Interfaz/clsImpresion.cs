using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    public class clsImpresion: intSalidas
    {
        public void ImprimeCliente(clsAbsClientes Cliente)
        {
            Console.WriteLine(Cliente.Clave + " " + Cliente.Nombre);
            Console.WriteLine(Cliente.TipoRegimen);
            Console.WriteLine(Cliente.RFC);
            Console.ReadKey();
        }

        public void ImprimeDireccion(clsDirecciones direccion)
        {
            Console.WriteLine(direccion.Calle);
            Console.WriteLine(direccion.Colonia);
            Console.WriteLine(direccion.Municipio);
            Console.ReadKey();
        }
    }
}
