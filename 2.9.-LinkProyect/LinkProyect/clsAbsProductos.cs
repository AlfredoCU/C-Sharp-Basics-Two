using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkProyect
{
    public abstract class clsAbsProductos
    {
        public abstract int IdProducto { get; set; }

        public abstract string Clave { get; set; }

        public abstract string Descripcion { get; set; }
    }
}
