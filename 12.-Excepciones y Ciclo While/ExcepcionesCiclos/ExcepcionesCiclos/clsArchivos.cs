using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesCiclos
{
    class clsArchivos: intSalidas
    {
        public void ImprimeCliente(clsAbsClientes Cliente)
        {
            int contador = 0;
            bool bandera = true;
            while (bandera)
            {
                try
                {
                    StreamWriter escritura = new StreamWriter("Clientes.txt", true);
                    escritura.WriteLine("-Nombre del cliente: " + Cliente.Nombre);
                    escritura.WriteLine("-Tipo de regimen: " + Cliente.TipoRegimen);
                    escritura.WriteLine("-RFC del cliente: " + Cliente.RFC);
                    escritura.Close();
                    bandera = false;
                }
                catch (Exception e)
                {
                    contador++;
                    if(contador == 1000)
                    {
                        throw e;
                    }
                }
            }
        }

        public void ImprimeDireccion(clsDirecciones direccion)
        {
            int contador = 0;
            bool bandera = true;
            while (bandera)
            {
                try
                {
                    StreamWriter escritura = new StreamWriter("Direcciones.txt", true);
                    escritura.WriteLine("-Calle: " + direccion.Calle);
                    escritura.WriteLine("-Colonia: " + direccion.Colonia);
                    escritura.WriteLine("-Municipio: " + direccion.Municipio);
                    escritura.Close();
                    bandera = false;
                }
                catch (Exception e)
                {
                    contador++;
                    if (contador == 1000)
                    {
                        throw e;
                    }
                }
            }
        }
    }
}