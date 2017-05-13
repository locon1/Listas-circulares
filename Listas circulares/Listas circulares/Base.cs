using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_circulares
{
    class Base
    {
        public string nombre { get; private set; }
        public int minutos { get; private set; }
        public Base siguiente { get; set; }

        public Base(string name, int minutes)
        {
            this.nombre = name;
            this.minutos = minutes;
        }

        public override string ToString()
        {
            return "Nombre: " + nombre + Environment.NewLine + "Tiempo: " + minutos;
        }
    }
}
