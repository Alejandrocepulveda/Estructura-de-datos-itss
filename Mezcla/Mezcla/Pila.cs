using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mezcla
{
    public class Nodo
    {
      
        public string CurpGato;
        public int EdadGato;
        public string RazaGato;
        public Nodo Siguiente;

    }

    internal class Pila
    {
        static Nodo ptrTope;
        static Nodo ptrNuevo;

        public void PILA()
        {
            ptrTope = null;
            ptrNuevo = null;
            string curpgato;
            int edadgato;
            string razagato;
            string r = "SI";

            while (r == "SI")
            {
                Console.WriteLine("Ingrese la curp del gato");
                curpgato = Console.ReadLine();
                Console.WriteLine("Ingrese la edad del gato");
                edadgato = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la raza del gato");
                razagato = Console.ReadLine();

                if (ptrTope == null)
                {
                    

                    ptrNuevo = new Nodo();

                    ptrNuevo.CurpGato = curpgato;
                    ptrNuevo.EdadGato = edadgato;
                    ptrNuevo.RazaGato = razagato;
                    ptrNuevo.Siguiente = null;

                    
                    ptrTope = ptrNuevo;



                }
                else
                {

                    ptrNuevo = new Nodo();
                    ptrNuevo.CurpGato=curpgato;
                    ptrNuevo.EdadGato = edadgato;
                    ptrNuevo.RazaGato = razagato;
                    ptrNuevo.Siguiente = ptrTope;

                    ptrTope = ptrNuevo;



                }

                Console.Write("Otro Nodo (SI/NO):");
                r = Console.ReadLine().ToUpper();
            }
            Console.WriteLine("*\n***Impresiones de la lista***\n");


            while (ptrTope != null)
            {
                Console.WriteLine("curp={0},edad={1},raza={2}", ptrTope.CurpGato, ptrTope.EdadGato, ptrTope.RazaGato);
                ptrTope = ptrTope.Siguiente;

            }

            
        }
    }
}
