using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario3
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //    int valor;
        //    string r = "SI";
            
        
            ArbolBinario arbol = new ArbolBinario();

        arbol.Insertar(10);
            arbol.Insertar(5);
            arbol.Insertar(15);
            arbol.Insertar(3);
            arbol.Insertar(7);
            arbol.Insertar(12);
            arbol.Insertar(20);

            //while (r=="SI")
            //{
            //    Console.WriteLine("Ingrese un valor");
            //    valor = int.Parse(Console.ReadLine());

            //    arbol.Insertar(valor);

            //    Console.WriteLine("Desea agregar otro valor");
            //    r = Console.ReadLine().ToUpper();
            //}

            Console.WriteLine("Altura del arbol: " + arbol.AlturaArbol(arbol.raiz));
            Console.WriteLine("Cantidad de nodos: " + arbol.CantidadNodos(arbol.raiz));

            arbol.RecorridoEnAmplitud();

            Console.WriteLine("\nRecorrido en PreOrden:");
            arbol.RecorridoPreOrden(arbol.raiz);

            Console.WriteLine("\nRecorrido en InOrden:");
            arbol.RecorridoInOrden(arbol.raiz);

            Console.WriteLine("\nRecorrido en PostOrden:");
            arbol.RecorridoPostOrden(arbol.raiz);

            Console.ReadLine();
        }
    }
}
