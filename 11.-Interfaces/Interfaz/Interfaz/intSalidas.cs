using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    interface intSalidas
    {
        // Deben de estar en la clase heredada.
        void ImprimeCliente(clsAbsClientes cliente);
        void ImprimeDireccion(clsDirecciones direccion);
    }
}
