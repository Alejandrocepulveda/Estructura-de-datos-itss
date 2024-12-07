using MetodosDeOrdenacionYBusqueda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDeOrdenacionYBusqueda
{
    class Program
    {
        static void Main(string[] args)
        { //Ejemplo de Metodo de ordenacion
            //Metodo burbuja

            int af = 0;
            int ad = 0;
            int aux = 0;
            int[] A = new int[] { 10, 5, 8, 11, 22 };//los recorridos

            //for (int i = 0; i < A.Length-1; i++)
            //{

            //    for (int j = 0; j < A.Length-1; j++)
            //    {
            //        if (A[j] > A[j + 1])
            //        {

            //            aux = A[j];
            //            A[j] = A[j + 1];
            //            A[j + 1] = aux;



            //        }


            //    }

            //}

            //for (int k = 0; k < A.Length; k++)
            //{
            //    Console.WriteLine(A[k]);


            //}

            var Lista = userDateConstants.ListaUsuario.Select(x => x);
            foreach (User item in Lista)
            {
                Console.Write($"{item.id}--> {item.Nombre}-->{item.edad}"); 
            }
            Console.ReadLine();
        }
    }
}
