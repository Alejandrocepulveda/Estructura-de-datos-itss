using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDLineales
{
    //Nodo
    public class Nodo
    {
        public string letras;
       public Nodo siguiente;

    }
    public class EstructurasLineales
    {
        public bool ListaVavia(Nodo ptr)
        {
            if (ptr==null)
            {
               
                return false;
            }
            else
            {
                return true;

            }
            
        }
        public void insertarnodos(ref Nodo cabecera,ref Nodo anterior,ref Nodo nuevo,string s )
        {
            if (!ListaVavia(cabecera)==true)
            {
                nuevo = new Nodo();
                nuevo.letras = s;
                nuevo.siguiente = null;
                cabecera = nuevo;
                anterior = nuevo;
                
            }
            else
            {
                nuevo = new Nodo();
                nuevo.letras = s;
                nuevo.siguiente = null;
                anterior.siguiente = nuevo;
                anterior = nuevo;
            }

        }

        public void RecorrerLista(Nodo cabecera)
        {
            //if (cabecera != null)
            if (ListaVavia(cabecera) == true)
            {
                Console.WriteLine(cabecera.letras);
                cabecera = cabecera.siguiente;
                RecorrerLista(cabecera);
            }
            else
            {
                return;
            }
        }
    }



}
