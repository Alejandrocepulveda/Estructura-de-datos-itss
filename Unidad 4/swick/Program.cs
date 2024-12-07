using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swick
{
    internal class Program
    {
        static Clase_Arbol arbolito;
        static Nodo nodo;
        static void Main(string[] args)
        {
            arbolito = new Clase_Arbol();
            Inicio();
        }

        private static int menu()
        {
            int valor = 0;
            Console.WriteLine("1- Ingresar Nodo");
            Console.WriteLine("2- Recorrer el arbol en preOrden");
            Console.WriteLine("3- Recorrer el arbol en PostOrden");
            Console.WriteLine("4- Recorrer el arbol en InOrden");
            Console.WriteLine("5- Altura del arbol");
            Console.WriteLine("6-  nivel");
            Console.WriteLine("7- Salir");
            valor = int.Parse(Console.ReadLine());
            return valor;


        }

        private static void Inicio()
        {
            int Opcion = 0;
            int valor = 0;

            while ((Opcion=menu())<7)
            {
                switch (Opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese El valor para ingresarlo al arbol");
                        valor = int.Parse(Console.ReadLine());
                        arbolito.insertar(ref nodo, valor);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("Recorrido en preorden");
                        arbolito.Preorden(nodo);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("Recorrido en posorden");
                        arbolito.PostOrden(nodo);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("Recorrido en Inorden");
                        arbolito.InOrden(nodo);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        Console.WriteLine("Altura del arbol: " + arbolito.Altura(nodo));
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 6:
                        Console.WriteLine(" nivel: " + arbolito.Nivel(nodo, valor));
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    
                    default:
                        break;
                }
            }
        }
    }
}
