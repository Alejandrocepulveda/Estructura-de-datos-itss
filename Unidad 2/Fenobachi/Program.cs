using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenobachi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ase;
            SerieFenobachi calculofi = new SerieFenobachi();
            Console.WriteLine("Ingrese un numero para inicar la serie de fibonacci");
            ase = int.Parse(Console.ReadLine());
            int iguana = calculofi.Fibonacci(ase);
            
            Console.WriteLine(iguana);
           
            Console.ReadLine();


        }
    }
}
