using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesCiclos
{
    public class clsImpresion: intSalidas
    {
        public void ImprimeCliente(clsAbsClientes Cliente)
        {
            Console.WriteLine("-Nombre del cliente: " + Cliente.Nombre);
            Console.WriteLine("-Tipo de regimen: " + Cliente.TipoRegimen);
            Console.WriteLine("-RFC del cliente: " + Cliente.RFC);
            Console.ReadKey();
        }

        public void ImprimeDireccion(clsDirecciones direccion)
        {
            Console.WriteLine("-Calle: " + direccion.Calle);
            Console.WriteLine("-Colonia: " + direccion.Colonia);
            Console.WriteLine("-Municipio: " + direccion.Municipio);
            Console.ReadKey();
        }
    }
}
