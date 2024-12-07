using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mezcla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo esc;
            string salir;
            string r;
            
            Pila GenerarPila = new Pila();
            Cola Generarcola = new Cola();
            Lista GenerarLista = new Lista();
            int insiso;
            Console.WriteLine("Bienvenido que desea hacer");
            
            
                inicio:
                Console.WriteLine("1- Generar Una Pila");
                Console.WriteLine("2- Generar Una Cola");
                Console.WriteLine("3- Generar Una Lista");
                Console.WriteLine("4- Salir del programa");
                insiso = int.Parse(Console.ReadLine());

            if (insiso == 1)
            {
            iniciopila:
                GenerarPila.PILA();

                Console.WriteLine("Desea generar otra pila?");
                r = Console.ReadLine().ToUpper();
                if (r == "SI")
                {
                    Console.Clear();
                    goto iniciopila;
                }
                else
                {
                    Console.Clear();
                    goto inicio;

                }

            }
            else if (insiso == 2)
            {
            iniciocola:
                Generarcola.COLA();

                Console.WriteLine("Desea generar otra cola?");
                r = Console.ReadLine().ToUpper();
                if (r == "SI")
                {
                    Console.Clear();
                    goto iniciocola;
                }
                else
                {
                    Console.Clear();
                    goto inicio;

                }


            }
            else if (insiso == 3)
            {
                iniciolista:
                GenerarLista.LISTA();

                Console.WriteLine("Desea generar otra Lista?");
                r = Console.ReadLine().ToUpper();
                if (r == "SI")
                {
                    Console.Clear();
                    goto iniciolista;
                }
                else
                {
                    Console.Clear();
                    goto inicio;

                }


            }
            else if(insiso==4)
            {
                Console.WriteLine("Realmente desea salir de este bello programa?");
                salir = Console.ReadLine().ToUpper();

                if (salir=="SI")
                {
                    do
                    {
                        Console.WriteLine("Entonces Presiona esc");
                        esc = Console.ReadKey();
                    } while (esc.Key !=ConsoleKey.Escape);
                    

                }
                else
                {
                    Console.WriteLine("Excelente decision ");
                    Console.Clear();
                    Console.ReadLine();
                        goto inicio;
                    
                }
            }











        }
    }
}
