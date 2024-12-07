using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen3
{
    internal class Program
    {
        static void Main(string[] args)
        {
         int np = 2;
           int ni = 1;
             int f = 1;

            Console.WriteLine("Ingrese Un Numero");
            int n = int.Parse(Console.ReadLine());

            GyMNum on = new GyMNum();

            Console.WriteLine("P  -  I  -  No");

            on.num(np, ni, f, n);
            Console.ReadLine();
        }
    }
}
