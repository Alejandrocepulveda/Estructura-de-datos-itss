using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manejo_Memoria
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uso del stack(Pila) Con el operador 
            //stackalloc(Reserva de memoria)
            //Definir un puntero(ptr)

            unsafe //Manejo de codigo no seguro
            {
                int lgth= 5;

            //puntero a un entero
           // int* ptr = stackalloc int[5] { 10, 20, 30, 40, 50 };
                int* ptr = stackalloc int[5];
           

                ptr[0] = 10;
                ptr[1] = 20;
                ptr[2] = 30;
                ptr[3] = 40;
                ptr[4] = 50;

                int[] numeros = new int[] { 60, 70, 80, 90, 100 };
                //numeros[0] = 60;
                //numeros[0] = 70;
                //numeros[0] = 80;
                //numeros[0] = 90;
                //numeros[0] = 100;



               for (int i = 0; i < lgth; i++)
            {
              Console.WriteLine(*ptr);
              ptr++;
            }
                //dar al puntero la dirrecion de memoria y limitarlo para evitar caos 
                fixed (int* ptr2 = &numeros[0])
                {

                    for (int i = 0; i < lgth; i++)
                    {
                        Console.WriteLine(ptr2[i]);

                    }
                }
            }
            Console.ReadLine();
        }
    }
}
