using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{

    public delegate void MuestraAvance(string valor);
    public class clsArchivoProductos
    {

        public event MuestraAvance avance;

        public void ObtenProductos(List<clsProductosBase> productos)
        {
            StreamReader sr = new StreamReader("Productos.txt", true);
            string cadena = sr.ReadLine();
            int i = 1;
            while(cadena != null)
            {
                string [] campos = cadena.Split(',');
                clsProductosBase prod = new clsProductosBase();
                prod.idProducto = Convert.ToInt32(campos[0]);
                prod.Clave = campos[1];
                prod.Descripcion = campos[2];
                productos.Add(prod);
                avance(i.ToString());
                i++;
                cadena = sr.ReadLine();
            }
            sr.Close();
        }
    }
}
