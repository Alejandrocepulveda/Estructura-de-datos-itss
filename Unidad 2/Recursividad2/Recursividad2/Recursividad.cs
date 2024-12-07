using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividad2
{
    public class Recursividad
    {
        public void Imprimir(int x)
            //metodo recursivo 
        {
            if (x > -1)// si es cero solo imprime hasta el uno por eso es mientras sea mayor a -1
            {
                Console.WriteLine(x);
                //primero imprime el valor actual de x para despues restarle 1 y volver a imprimirlo
                Imprimir(x - 1);
            }
        }
    }
}
