using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swick
{
    internal class Nodo
    {
        public Nodo derecha;
        public Nodo izquierda;
        public int valor;

        public Nodo(int val)
        {
            valor = val;
            derecha = null;
            izquierda = null;
        }
    }
}
