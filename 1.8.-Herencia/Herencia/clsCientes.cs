using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class clsCientes
    {
        private int _IdCliente;
        private string _Nombres;
        private string _Apellido;

        public int IdCliente
        {
            get { return _IdCliente;}
            set { _IdCliente = value;}
        }

        public string Nombres
        {
            get { return _Nombres;}
            set { _Nombres = value;}
        }

        public string Apellido
        {
            get { return _Apellido;}
            set { _Apellido = value;}
        }
    }
}
