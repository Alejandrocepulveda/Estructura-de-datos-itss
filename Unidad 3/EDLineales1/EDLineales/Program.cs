using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDLineales
{
    class Program
    {
        static Nodo cabecera;
        static Nodo anterior;
        static Nodo nuevo;
        static void Main(string[] args)
        {
            cabecera = null;
            anterior = null;
            nuevo = null;

            EstructurasLineales lista = new EstructurasLineales();

            string continuar = "SI";
            while (continuar=="SI")
            {
                Console.WriteLine("letra:");
                string s = Console.ReadLine();
                lista.insertarnodos(ref cabecera, ref anterior,  ref nuevo,  s);
                Console.WriteLine("Otro letra de la lista(SI/NO):");
                continuar = Console.ReadLine().ToUpper();
            }

            lista.RecorrerLista(cabecera);
            Console.ReadLine();
        }
    }
}
