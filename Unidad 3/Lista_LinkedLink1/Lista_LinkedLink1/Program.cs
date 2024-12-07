using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_LinkedLink1
{
    class Cliente
    {
        public string rfc { get; set; }
        public string nombre { get; set; }
        public int edad { get; set; }
        public string niveldeEstudios { get; set; }
    }
    class Program
    {
       static LinkedList<Cliente> Lista;
        static void Main(string[] args)
        {
            Lista = new LinkedList<Cliente>();
            Lista.AddLast(new Cliente { rfc = "Cefa445Kaas", nombre = "Jose Alejandro Cepulveda Fonseca", edad = 19,niveldeEstudios="Ingenieria"});
            Lista.AddLast(new Cliente { rfc = "EAHdd5695", nombre = "Emmanuel Alvarez Hernandez", edad = 18,niveldeEstudios="Licenciatura"});

            foreach (Cliente item in Lista)//in que se encuentra en 
            {
                Console.WriteLine("Rfc:{0},Nombre:{1},Edad:{2},Nivel de Estudios:{3}",item.rfc,item.nombre,item.edad,item.niveldeEstudios);
                
            }
            Console.WriteLine("Rosario deja mi chilito");
            Console.ReadLine();
        }
    }
}
