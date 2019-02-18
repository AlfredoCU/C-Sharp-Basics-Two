using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            clsClientesConContacto Cliente = new clsClientesConContacto(0, "Alfredo Carreón Urbano", 
            "pass4edf", "8784ASDE", 1, "33745498561","36459014","alfcu@gmail.com",
            "Agnesi","7548","A","Hierro","Lomas","Jalisco","7415");

            clsImpresion Impresion;
            Impresion = new clsImpresion();
            Impresion.ImprimeCliente(Cliente);
        }
    }
}