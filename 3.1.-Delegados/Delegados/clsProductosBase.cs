using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    public class clsProductosBase : clsAbsProductos
    {
        public override int idProducto { get; set; }

        public override string Clave { get; set; }

        public override string Descripcion { get; set; }
    }
}
