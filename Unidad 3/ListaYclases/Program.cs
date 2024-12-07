using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaYclases
{
    internal class Program
    {
        static LinkedList<DatosPersonales> ListaPersonas = new LinkedList<DatosPersonales>();
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número de veces que desea ingresar los datos:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                DatosPersonales persona = new DatosPersonales();

                Console.WriteLine("Ingrese un RFC:");
                persona.Rfc = Console.ReadLine();
                Console.WriteLine("Ingrese el nombre:");
                persona.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la edad:");
                persona.Edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el grado académico:");
                persona.NivelDeEstudios = Console.ReadLine();

                ListaPersonas.AddLast(persona);
            }

            foreach (DatosPersonales item in ListaPersonas)
            {
                Console.WriteLine($"RFC: {item.Rfc}, Nombre: {item.Nombre}, Edad: {item.Edad}, Nivel Académico: {item.NivelDeEstudios}");
            }

            Console.ReadLine();
        }
    }
}
