using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoUnidad3_EL_COLA
{
    public class Nodo
    {
        //Campos con sus tipos de datos
        //Campos para almacenar datos
        public int idTel;
        public string marcatel;
        public string modelotel;
        //Campos para enlzar al siguiente nodo de la lista
        public Nodo Siguiente;

    }
    internal class Program
    {
        static Nodo Frente;
        static Nodo Final;
        static Nodo nuevonodo;
        static void Main(string[] args)
        {
            Frente = null;
            Final = null;
            nuevonodo = null;
            string repuesta = "SI";
            int indice = 1;

            while (repuesta=="SI")
            {
                Console.Write("Marca :");
                string marca = Console.ReadLine();
                Console.Write("Modelo: ");
                string modelo = Console.ReadLine();

                if (Frente == null)
                {
                    nuevonodo = new Nodo();
                    nuevonodo.idTel = indice;
                    nuevonodo.marcatel = marca;
                    nuevonodo.modelotel = modelo;
                    Frente = nuevonodo;
                    Final = nuevonodo;
                }
                else
                {
                    nuevonodo = new Nodo();
                    nuevonodo.idTel = indice;
                    nuevonodo.marcatel = marca;
                    nuevonodo.modelotel = modelo;
                    Final.Siguiente = nuevonodo;
                    Final = nuevonodo;

                }
                Console.Write("Otro Nodo (SI/NO):");
                repuesta = Console.ReadLine().ToUpper();
            }

            Console.WriteLine("*\n***Impresiones de la lista***\n");

            while (Frente!= null)
            {
                Console.WriteLine("Id={0},marca={1},modelo={2}", Frente.idTel, Frente.marcatel, Frente.modelotel);
                Frente = Frente.Siguiente;
               

            }

            Console.ReadLine();
        }
    }
}
