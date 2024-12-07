using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mezcla
{
    public class nodo
    {
        //Campos con sus tipos de datos
        //Campos para almacenar datos
        public int idTCar;
        public string marcar;
        public string modelo;
        //Campos para enlzar al siguiente nodo de la lista
        public nodo Siguiente;

    }
    internal class Cola
    {
        static nodo Frente;
        static nodo Final;
        static nodo nuevonodo;

        public void COLA()
        {
            Frente = null;
            Final = null;
            nuevonodo = null;
            string repuesta = "SI";
            int indice = 1;
            string marca, model;

            while (repuesta == "SI")
            {
                Console.WriteLine("Ingrese la marca del vehiculo");
                marca = Console.ReadLine();
                Console.WriteLine("Ingrese el del vehiculo");
                model = Console.ReadLine();

                if (Frente == null)
                {
                    nuevonodo = new nodo();
                    nuevonodo.idTCar = indice;
                    nuevonodo.marcar= marca;
                    nuevonodo.modelo = model;
                    Frente = nuevonodo;
                    Final = nuevonodo;
                }
                else
                {
                    indice++;
                    nuevonodo = new nodo();
                    nuevonodo.idTCar = indice;
                    nuevonodo.marcar = marca;
                    nuevonodo.modelo = model;
                    Final.Siguiente = nuevonodo;
                    Final = nuevonodo;

                }
                Console.Write("Otro Nodo (SI/NO):");
                repuesta = Console.ReadLine().ToUpper();
            }

            Console.WriteLine("*\n***Impresiones de la lista***\n");

            while (Frente != null)
            {
                Console.WriteLine("Id={0},marca={1},modelo={2}", Frente.idTCar, Frente.marcar, Frente.modelo);
                Frente = Frente.Siguiente;


            }

        }
    }
}
