using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Dinamica
{
    class DatosPersonales
    {
        public string rfc { get; set; }
        public string nombre { get; set; }
        public int edad { get; set; }
        public string niveldeEstudios { get; set; }
    }
    internal class Program
    {
        static LinkedList<DatosPersonales> ListaPersonas;
     
        static void Main(string[] args)
        {
            ListaPersonas = new LinkedList<DatosPersonales>();

            string RFC;
            string NOMBRE;
            int EDAD;
            string NivelAcademico;
            int n;

            Console.WriteLine("Ingrese El numero de veces que desea ingresar los datos");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i <n; i++)
            {
                Console.WriteLine("Ingrese Un RFC");
                RFC = Console.ReadLine();
                Console.WriteLine("Ingrese El nombre");
                NOMBRE = Console.ReadLine();
                Console.WriteLine("Ingrese La edad");
                EDAD = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese El grado academico");
                NivelAcademico = Console.ReadLine();
               
                ListaPersonas.AddLast(new DatosPersonales { rfc = RFC, nombre = NOMBRE, edad = EDAD, niveldeEstudios = NivelAcademico });
                foreach (DatosPersonales item in ListaPersonas)
                {
                    Console.WriteLine("RFC{0}:,NOMBRE{1}:,EDAD{2}:,NIVELACADEMICO{3}:",item.rfc,item.nombre,item.edad,item.niveldeEstudios);
                }
            }
            Console.ReadLine();
        }
    }
}
