using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLNQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //vamos a gestionar un array con LNQ
            int[] A = new int[] { 35, 42, 8, 15, 32 };
            var Lista = (from num in A
                         //Criterios para aplicar al array a
                         //Para que selecione solo numero pares
                         //let n = num % 2 == 0
                         // where num %2==0---->"Numero pares"

                         //where num % 2 == 1----> "Numero pares"

                         //where num >1&& num <20

                         //select num).Where(x => x > 15).ToList();
                         //select num).Where(x => x > 15 && x < 50).OrderBy(x => x);

                         select num).Average();

                        //select num).OrderByDescending(x=>x);
            Console.WriteLine(Lista);
            //foreach (var item in Lista )
            //{
            //    Console.WriteLine(item);
            //}
            Console.ReadLine();
        }
    }
}
