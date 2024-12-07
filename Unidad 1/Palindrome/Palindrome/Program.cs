using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Escribe La cadena:");
             //var es una palabra que forza al compilador a adaptarse al tipo de dato ingresado
            var cad = Console.ReadLine().ToUpper();//Toupper funciona para convertir minusculas en mayusculas   
            int L = cad.Length;//longitud de la cadena
            var adelante = "";
            var atras = "";

            unsafe
            {
                fixed(char* ptr =cad)
                {
                    for (int i = 0; i < L; i++)
                    {
                        if (ptr[i].ToString()!=" ")
                        {
                            adelante += ptr[i];
                        }
                        //Console.WriteLine(ptr[i]);
                    }

                    Console.WriteLine(adelante);

                    for (int i = L-1; i > -1; i--)
                    {
                        if (ptr[i].ToString() != " ")
                        {
                            atras += ptr[i];
                        }
                     
                    }
                    Console.WriteLine(atras);
                    if (atras==adelante)
                    {
                        Console.WriteLine("La palabra es palindroma");
                    }
                    else
                    {
                        Console.WriteLine("La palabra NO es palindroma");
                    }
                   
                }

            }

            Console.ReadLine();

        }
    }
}
