using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repasounidad_LE_PILA
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
    class Program
    {
        static Nodo ptrTope;
        static Nodo ptrNuevo;
        static void Main(string[] args)
        {
            ptrTope = null;
            ptrNuevo = null;

            string repuesta = "SI";
            int indice = 1;
           

            while(repuesta=="SI")
            {
                Console.Write("Marca :");
                string marca = Console.ReadLine();
                Console.Write("Modelo: ");
                string modelo = Console.ReadLine();


                if (ptrTope == null)
                {
                    //Crear el primer nodo en memoria 
                    //apuntado por ptr nuevo 

                    ptrNuevo = new Nodo();
                    //Asignar los datos a los campos del nodo apuntado por ptrNuevo
                    ptrNuevo.idTel = indice;
                    ptrNuevo.marcatel = marca;
                    ptrNuevo.modelotel = modelo;
                    ptrNuevo.Siguiente = null;

                    //Referenciar al primer nodo creado con ptrTope
                    //Para que no se pierda cuando ptrNuevo se use para crear el siguiente nodo de la lista
                    ptrTope = ptrNuevo;
      

                    
                }
                else
                {
                    //incrementar el identificador de los datos del nodo 
                    indice++;
                    //Crear el siguiente nodo 

                    ptrNuevo = new Nodo();
                    ptrNuevo.idTel = indice;
                    ptrNuevo.marcatel = marca;
                    ptrNuevo.modelotel = modelo;
                    ptrNuevo.Siguiente = ptrTope;

                    ptrTope = ptrNuevo;



                }

                Console.Write("Otro Nodo (SI/NO):");
                repuesta = Console.ReadLine().ToUpper();
            }
            Console.WriteLine("*\n***Impresiones de la lista***\n");


            while (ptrTope != null)
            {
                Console.WriteLine("Id={0},marca={1},modelo={2}", ptrTope.idTel, ptrTope.marcatel, ptrTope.modelotel);
                ptrTope = ptrTope.Siguiente;

            }

            Console.ReadLine();

            

        }
    }
}
