using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinarioDeBusqueda
{
    class Program
    {
        static ArbolBinario Arbol = new ArbolBinario();
        static Nodo raiz;
        static void Main(string[] args)
        {
            string r = "SI";
            int n;
            int id=0;
            raiz = null;
            //Insertar Nodos

            while (r=="SI")
            {
                Console.WriteLine("Ingrese un numero");
                n = int.Parse(Console.ReadLine());
                //Console.WriteLine("Ingrese un id");
                //id = int.Parse(Console.ReadLine());
                //Por si se quiere ingresar manualmente el id 
                Arbol.InsertarNodos(ref raiz, id, n);

                Console.Write("Desea ingresar mas datos: ");
                r = Console.ReadLine().ToUpper();
                id++;
            }

            //metodo para el recorrido

            //Preorden 
            Console.WriteLine("Preorden");
            Arbol.PreOrden(ref raiz, "raiz");
            //Inorden
            Console.WriteLine("Inorden");
            Arbol.InOrden(ref raiz, "raiz");
            //preorden
            Console.WriteLine("PostOrden");
            Arbol.PostOrden(ref raiz, "raiz");

             
            Console.WriteLine("La cantidad de nodos es {0}",id);
            Console.ReadLine();

        }
    }
}
