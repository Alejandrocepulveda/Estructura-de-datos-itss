using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mezcla
{
    public class NODO   
    {
        //Campos con sus tipos de datos
        //Campos para almacenar datos
        public int idTel;
        public string marcatel;
        public string modelotel;
        //Campos para enlzar al siguiente nodo de la lista
        public NODO Siguiente;

    }
    internal class Lista
    {
        public static NODO PtrCabecera;
        public static NODO PtrActual; //equivalente al nodo ptranteriro
        public static NODO PtrNuevo;

        public void LISTA()
        {
            PtrCabecera = null;
            PtrActual = null;
            PtrNuevo = null;
            string marca, modelo;

            Console.WriteLine("Desea Ingresar al ciclo");
            string Respuesta = Console.ReadLine();//"SI"
            int indice = 1;

            while (Respuesta.ToUpper() == "SI")
            {
                Console.WriteLine("Ingrese la marcar del dispositivo");
                marca = Console.ReadLine();
                Console.WriteLine("Ingrese el modelo del dispositivo");
                modelo = Console.ReadLine();

                if (PtrCabecera == null)
                {
                    PtrNuevo = new NODO();
                    PtrNuevo.idTel = indice;
                    PtrNuevo.marcatel = marca;
                    PtrNuevo.modelotel = modelo;
                    PtrNuevo.Siguiente = null;

                    PtrCabecera = PtrNuevo;
                    PtrActual = PtrNuevo;
                }
                else
                {
                    indice++;

                    PtrNuevo = new NODO();
                    PtrNuevo.idTel = indice;
                    PtrNuevo.marcatel = marca;
                    PtrNuevo.modelotel = modelo;
                    PtrNuevo.Siguiente = null;

                    //PtrCabecera = PtrNuevo;
                    PtrActual.Siguiente = PtrNuevo;
                    PtrActual = PtrNuevo;

                }

                Console.WriteLine("Otro nodo(SI/NO)");
                Respuesta = Console.ReadLine();

            }

            Console.WriteLine("*\n***Impresiones de la lista***\n");


            while (PtrCabecera != null)
            {
                Console.WriteLine("Id={0},marca={1},modelo={2}", PtrCabecera.idTel, PtrCabecera.marcatel, PtrCabecera.modelotel);
                PtrCabecera = PtrCabecera.Siguiente;

            }

        }
    }
}
