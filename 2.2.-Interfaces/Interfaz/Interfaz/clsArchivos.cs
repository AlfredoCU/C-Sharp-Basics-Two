using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    class clsArchivos: intSalidas
    {
        public void ImprimeCliente(clsAbsClientes Cliente)
        {
            StreamWriter escritura = new StreamWriter("Clientes.txt", true);
            escritura.WriteLine(Cliente.Clave + " " + Cliente.Nombre);
            escritura.WriteLine(Cliente.TipoRegimen);
            escritura.WriteLine(Cliente.RFC);
            escritura.Close();
        }

        public void ImprimeDireccion(clsDirecciones direccion)
        {
            StreamWriter escritura = new StreamWriter("Direcciones.txt", true);
            escritura.WriteLine(direccion.Calle);
            escritura.WriteLine(direccion.Colonia);
            escritura.WriteLine(direccion.Municipio);
            escritura.Close();
        }
    }
}
