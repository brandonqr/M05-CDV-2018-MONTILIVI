using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPersona
{
    class Vendedor
    {
        private string nombre;
        private int ventas;
        private string nombreEmpresa;

        public Vendedor(string nombre, int ventas, string nombreEmpresa)
        {
            this.nombre = nombre;
            this.ventas = ventas;
            this.nombreEmpresa = nombreEmpresa;
        }
    }
}
