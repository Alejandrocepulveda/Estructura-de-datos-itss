﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Fenobachi
{
    internal class SerieFenobachi
    {
       public int Fibonacci (int n )
        {
           if(n==0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
           
                    
                    
                    
                    
                    
        }
       

    }
}
