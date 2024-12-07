using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilaClase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassPila pila = new ClassPila();

            
            Console.WriteLine("Ingrese el numero de datos a ingresar ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Ingrese el rfc ");
                string RFC = Console.ReadLine();
                Console.WriteLine("Ingrese el nombre ");
                string NOMBRE = Console.ReadLine();
                Console.WriteLine("Ingrese la edad ");
                int EDAD = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el grado academico  ");
                string GRADOA_CADEMICO = Console.ReadLine();
                pila.DatosCliente(RFC, NOMBRE, EDAD, GRADOA_CADEMICO, n);
            }

           

            Console.ReadLine();
        }
    }
}
