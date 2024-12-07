using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilaClase
{
    class Cliente
    {
        public string rfc { get; set; }
        public string nombre { get; set; }
        public int edad { get; set; }
        public string niveldeEstudios { get; set; }
    }
    internal class ClassPila
    {
        public static Queue<Cliente> cola;

        public void DatosCliente(string RFC,string NOMBRE,int EDAD,string GRADOA_CADEMICO,int n)
        {
            cola = new Queue<Cliente>();
            cola.Enqueue(new Cliente { rfc = RFC, nombre = NOMBRE, edad = EDAD, niveldeEstudios = GRADOA_CADEMICO });
            //for (int i = 0; i < n; i++)
            //{


            //}

            foreach (Cliente item in cola)
            {
                Console.WriteLine("Rfc:{0},Nombre:{1},Edad:{2},Nivel de Estudios:{3}", item.rfc, item.nombre, item.edad, item.niveldeEstudios);
            }
        }
    }
}
