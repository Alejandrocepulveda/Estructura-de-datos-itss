using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RePAsoUnidad3_El_COLA1
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
        static Nodo PtrNuevo;
        static Nodo PtrFrente;
        static Nodo PtrFinal;
        static void Main(string[] args)
        {
            PtrFrente = null;
            PtrFinal = null;
            PtrNuevo = null;
            int Indice = 1;

            string r = "SI";
            while (r == "SI")
            {
                Console.Write("Marca :");
                string marca = Console.ReadLine();
                Console.Write("Modelo: ");
                string modelo = Console.ReadLine();

                if (PtrFrente == null)
                {
                    PtrNuevo = new Nodo();
                    PtrNuevo.idTel = Indice;
                    PtrNuevo.marcatel = marca;
                    PtrNuevo.modelotel = modelo;
                    //Referenciar el primer nodo creado con PTRFRENTE y PTRFINAL
                    //PTRFRENTE es para que no se pierda la cola cuando 
                    //Ptrnuevo se use para crear el siguiente nodo de la lista 
                    //ptrfinal se usara para apuntar al nodo actual y enlazar con el siguiente nodo nuevo
                    PtrFrente = PtrNuevo;
                    PtrFinal = PtrNuevo;
                }
                else
                {
                    //Incrementa el indice de los telefonos 
                    Indice++;
                    //Crea un nuevo nodo de la cola
                    PtrNuevo = new Nodo();
                    //Asignar los datos a los campos del nodo nuevo apuntado por ptr nuevo
                    PtrNuevo.idTel = Indice;
                    PtrNuevo.marcatel = marca;
                    PtrNuevo.modelotel = modelo;
                    //El campo siguiente del nodo apuntado por ptrfinal es igual a ptrnuevo
                    PtrFinal.Siguiente = PtrNuevo;
                    PtrFinal = PtrNuevo;

                }

                Console.WriteLine("Otro Nodo");
                r = Console.ReadLine().ToUpper();
            }

            //recorrer la lista en forma de cola 
            Console.WriteLine("*\n***Impresiones de la cola***\n");

            while (PtrFrente!= null)
            {
                Console.WriteLine("Id={0},marca={1},modelo={2}", PtrFrente.idTel, PtrFrente.marcatel, PtrFrente.modelotel);
                PtrFrente = PtrFrente.Siguiente;
               

            }

            Console.ReadLine();
        }
        }
    }

