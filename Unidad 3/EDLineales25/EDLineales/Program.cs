using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDLineales
{
    class Program
    {
        //Punteros para una lista enlazada
          
        static Nodo cabecera;
        static Nodo anterior;
        static Nodo nuevo;
        //Punteros para una pila(Stack)
        static Nodo Tope;
        static Nodo Nuevo;
        static void Main(string[] args)
        {
            //iniciar punteros para una lista enlazada
           
            cabecera = null;
            anterior = null;
            nuevo = null;

            //inicar punteros para una pila(Stack)

            EstructurasLineales lista = new EstructurasLineales();
        
            string continuar = "SI";
            while (continuar=="SI")
            {
                Console.WriteLine("Valor:");
                int n = int.Parse(Console.ReadLine());
                lista.push(ref Tope, ref Nuevo, n);
                Console.WriteLine("Otro elemento de la lista(SI/NO):");
                continuar = Console.ReadLine().ToUpper();
                //lista.insertarnodos(ref cabecera, ref anterior,  ref nuevo,  n);
                //Console.WriteLine("Otro elemento de la lista(SI/NO):");
                //continuar = Console.ReadLine().ToUpper();
            }

            lista.pop(Tope);
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Lino es puto");
            Console.ReadLine();
        }
    }
}
