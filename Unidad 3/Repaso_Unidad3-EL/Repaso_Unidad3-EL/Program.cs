using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_Unidad3_EL
{
    //Estructura de los nodos
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
        //Punteros a los nodos de la lista 
       public static Nodo PtrCabecera;
       public static Nodo PtrActual; //equivalente al nodo ptranteriro
        public static Nodo PtrNuevo;
        static void Main(string[] args)
        {
            PtrCabecera=null;
            PtrActual=null;
            PtrNuevo=null;

            Console.WriteLine("Desea Ingresar al ciclo"); 
            string Respuesta=Console.ReadLine();//"SI"
            int indice=1;
           
            while(Respuesta.ToUpper()=="SI")
            {
                Console.Write("Marca :");
                string marca= Console.ReadLine();
                Console.Write("Modelo: ");
                string modelo=Console.ReadLine();

                if (PtrCabecera==null)
                {
                   PtrNuevo=new Nodo();
                    PtrNuevo.idTel=indice;
                    PtrNuevo.marcatel=marca;
                    PtrNuevo.modelotel=modelo;
                    PtrNuevo.Siguiente=null;

                    PtrCabecera = PtrNuevo;
                    PtrActual = PtrNuevo;
                }
                else
                {
                    indice++;

                    PtrNuevo = new Nodo();
                    PtrNuevo.idTel = indice;
                    PtrNuevo.marcatel = marca;
                    PtrNuevo.modelotel = modelo;
                    PtrNuevo.Siguiente = null;

                    //PtrCabecera = PtrNuevo;
                    PtrActual.Siguiente=PtrNuevo;
                    PtrActual = PtrNuevo;

                }

                Console.WriteLine("Otro nodo(SI/NO)");
                Respuesta = Console.ReadLine();
	
            }

            Console.WriteLine("*\n***Impresiones de la lista***\n");


            while (PtrCabecera!=null)
            {
                Console.WriteLine("Id={0},marca={1},modelo={2}",PtrCabecera.idTel,PtrCabecera.marcatel,PtrCabecera.modelotel);
                PtrCabecera = PtrCabecera.Siguiente;

            }

            Console.ReadLine();
        }
    }
}
