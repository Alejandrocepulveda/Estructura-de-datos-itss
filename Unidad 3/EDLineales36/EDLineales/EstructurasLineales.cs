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
       public int numero;
       public Nodo siguiente;

    }
    public class EstructurasLineales
    {
        //Nodo Nuevo = null;
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
        public void insertarnodos(ref Nodo cabecera,ref Nodo anterior,ref Nodo nuevo,int n )
        {
            if (!ListaVavia(cabecera)==true)
            {
                nuevo = new Nodo();
                nuevo.numero = n;
                nuevo.siguiente = null;
                cabecera = nuevo;
                anterior = nuevo;
                
            }
            else
            {
                nuevo = new Nodo();
                nuevo.numero = n;
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
                Console.WriteLine(cabecera.numero);
                cabecera = cabecera.siguiente;
                RecorrerLista(cabecera);
            }
            else
            {
                return;
            }
        }

        public void push(ref Nodo Tope,ref Nodo Nuevo, int N)
        {
            //if (!ListaVavia(Tope) == true)
            if (Tope==null)
            {
               Nuevo= new Nodo();
                Nuevo.numero = N;
                Nuevo.siguiente = null;
                Tope = Nuevo;
              
            }
            else
            {
                Nuevo = new Nodo();
                Nuevo.numero = N;
                Nuevo.siguiente = Tope;
                Tope = Nuevo;
            }
        }

        public void pop(Nodo Tope)
        {
            if(Tope!=null)
            {
                Console.WriteLine(Tope.numero);
                Tope = Tope.siguiente;
                pop(Tope);
            }
        }

        public void Queue(ref Nodo Frente, ref Nodo Final, ref Nodo nuevonodo, int n )
        {
            if (!ListaVavia(Frente) == true)
            {
                nuevonodo = new Nodo();
                nuevonodo.numero = n;
                nuevonodo.siguiente= null;
                Frente = nuevonodo;
                Final = nuevonodo;
            }
            else
            {
                nuevonodo = new Nodo();
                nuevonodo.numero = n;
                nuevonodo.siguiente = null;
                Final.siguiente = nuevonodo;
                Final = nuevonodo;

            }

            
        }

        public void Dequeque(Nodo Frente)
        {
              if (ListaVavia(Frente) ==true)
              {
                  Console.WriteLine(Frente.numero);
                  Frente = Frente.siguiente;
                  Dequeque(Frente);

              }
        }
    }



}
