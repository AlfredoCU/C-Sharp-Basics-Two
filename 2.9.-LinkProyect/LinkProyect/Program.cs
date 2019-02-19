using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkProyect
{
    class Program
    {
        static void Main(string[] args)
        {

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////
            
            // Ayuda a clalcular el tiempo transcurrido en un algoritmo.
            Stopwatch reloj = new Stopwatch();
            ctrPresentacion13 ctrl = new ctrPresentacion13();
            ctrl.LlenarLista();
            Impresion.ImprimeProductos(ctrl.Productos);
            List<clsProductosInventario> prodSinExistencia = new List<clsProductosInventario>();
            Impresion.EsperaTecla();
            Impresion.ImprimeTiempo(reloj.ElapsedTicks);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            reloj.Start();
            foreach (var prod in ctrl.Productos)
            {
                if (prod.Existencias <= 0)
                    prodSinExistencia.Add(prod);
            }
            Impresion.ImprimeProductos(prodSinExistencia);
            reloj.Stop();

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Impresion.ImprimeTiempo(reloj.ElapsedTicks);
            Impresion.EsperaTecla();
            prodSinExistencia.Clear();
            reloj.Reset();
            Impresion.ImprimeTiempo(reloj.ElapsedTicks);
            reloj.Start();
            prodSinExistencia.AddRange(from o in ctrl.Productos where o.Existencias > 0 && o.PrecioPublico <= 13 select o);
            Impresion.ImprimeProductos(prodSinExistencia);
            reloj.Stop();
            Impresion.ImprimeTiempo(reloj.ElapsedTicks);
            Impresion.EsperaTecla();

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////
            var lista = (from o in ctrl.Productos group o by o.Costo into g select new { g.Key, Total = g.Sum(t => t.Existencias * t.PrecioPublico) }).ToList();
            foreach (var item in lista)
            {
                Console.WriteLine("Total: {0} Costo: {1} ", item.Total, item.Key);
            }
            Impresion.EsperaTecla();

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}