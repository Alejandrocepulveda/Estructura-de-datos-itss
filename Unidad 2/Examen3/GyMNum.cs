using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen3
{
    internal class GyMNum
    {
        public int num (int p,int i, int f,int l)
        {
            if(f>l)
            {
                return 0;
            }
            Console.WriteLine($"{p}  -  {i}  -  {f}");
            return num(p + 2, i + 2, f + 1,l);
        }
    }
}
