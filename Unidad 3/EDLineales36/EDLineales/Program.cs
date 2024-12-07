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
        //Punteros para una cola
        static Nodo Frente;
        static Nodo Final;
        static Nodo nuevonodo;
        static void Main(string[] args)
        {
            //iniciar punteros para una lista enlazada
           
            cabecera = null;
            anterior = null;
            nuevo = null;

            //inicar punteros para una pila(Stack)

            //Inicar puntero de una cola(queque)
            Frente = null;
            Final = null;
            nuevonodo = null;

            EstructurasLineales lista = new EstructurasLineales();
        
            string continuar = "SI";
            while (continuar=="SI")
            {
                Console.WriteLine("Valor:");
                int n = int.Parse(Console.ReadLine());
                lista.Queue(ref Frente, ref Final,ref nuevonodo,n);
                Console.WriteLine("Otro elemento de la Cola (SI/NO):");
                continuar = Console.ReadLine().ToUpper();
                //lista.push(ref Tope, ref Nuevo, n);
                //Console.WriteLine("Otro elemento de la Pila (SI/NO):");
                //continuar = Console.ReadLine().ToUpper();
                //lista.insertarnodos(ref cabecera, ref anterior,  ref nuevo,  n);
                //Console.WriteLine("Otro elemento de la Lista (SI/NO):");
                //continuar = Console.ReadLine().ToUpper();
            }

            lista.Dequeque(Frente);
         
            Console.ReadLine();
        }
    }
}
