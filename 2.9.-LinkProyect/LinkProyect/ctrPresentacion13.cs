using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkProyect
{
    public class ctrPresentacion13
    {
        public ctrPresentacion13()
        {
            _Productos = new List<clsProductosInventario>();
        }
        private List<clsProductosInventario> _Productos;

        public List<clsProductosInventario> Productos
        {
            get { return _Productos; }
            set { _Productos = value; }
        }

        public void LlenarLista()
        {
            Productos.Clear();
            Productos.Add(new clsProductosInventario() { IdProducto = 124, Clave = "P0001", 
                                                        Descripcion = "GTA CRAKETS 200g", PrecioPublico = 12.5m, 
                                                        Costo = 11.5m, Existencias = 0});
            Productos.Add(new clsProductosInventario() { IdProducto = 125, Clave = "P0022", 
                                                        Descripcion = "GTA MVILLAS 200g", PrecioPublico = 12.5m, 
                                                        Costo = 11.5m, Existencias = 3});
            Productos.Add(new clsProductosInventario() { IdProducto = 128, Clave = "P0034", 
                                                        Descripcion = "GTA MEXICANA 200g", PrecioPublico = 12.5m, 
                                                        Costo = 11.5m, Existencias = -4});
            Productos.Add(new clsProductosInventario() { IdProducto = 134, Clave = "P0045", 
                                                        Descripcion = "HIG LYS PAQ4PZAS", PrecioPublico = 23.5m, 
                                                        Costo = 18.5m, Existencias = 20});
            Productos.Add(new clsProductosInventario() { IdProducto = 141, Clave = "P0066", 
                                                        Descripcion = "HIG CHAR PAQ4PZAS", PrecioPublico = 31.0m, 
                                                        Costo = 27.5m, Existencias = 8});
            Productos.Add(new clsProductosInventario() { IdProducto = 167, Clave = "P0091", 
                                                        Descripcion = "SOPA NISSIN 600 g", PrecioPublico = 28.5m, 
                                                        Costo = 21.5m, Existencias = 0});
            Productos.Add(new clsProductosInventario() { IdProducto = 181, Clave = "P0098", 
                                                        Descripcion = "COCA COLA 600ML", PrecioPublico = 11.5m, 
                                                        Costo = 9.5m, Existencias = 45});
            Productos.Add(new clsProductosInventario() { IdProducto = 182, Clave = "P0099", 
                                                        Descripcion = "COCA COLA 2L", PrecioPublico = 35.5m, 
                                                        Costo = 28.5m, Existencias = 16});
       }
    }
}
