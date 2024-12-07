using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinarioDeBusqueda
{
    public class Nodo
    {
        public int id { get; set; }
        public int n { get; set; }

        public Nodo Izquierda;
        public Nodo Derecha;
    }
    public class ArbolBinario
    {

        public void InsertarNodos(ref Nodo ptrRaiz, int id, int n)
        {
            if (ptrRaiz == null)
            {
                ptrRaiz = new Nodo()
                {
                    id = id,
                    n = n,
                    Izquierda = null,
                    Derecha = null

                };
            }
            else 
            {
                if(n<ptrRaiz.n)
                {
                    InsertarNodos(ref ptrRaiz.Izquierda,id,n);
                }
                else
                {
                    InsertarNodos(ref ptrRaiz.Derecha, id, n);
                }
            }
        }


        public void PreOrden(ref Nodo ptrRaiz, string nodovisitado)
        {
            if (ptrRaiz!=null)
            {
                Console.WriteLine("{0}->{1}->{2}", ptrRaiz.id, ptrRaiz.n, nodovisitado);
                PreOrden(ref ptrRaiz.Izquierda, "Izquierda");
                PreOrden(ref ptrRaiz.Derecha, "Derecha");
              
            }
            
         
        }

        public void InOrden(ref Nodo ptrRaiz, string nodovisitado)
        {
            if (ptrRaiz!=null)
            {
                InOrden(ref ptrRaiz.Izquierda, "izquierda");
                Console.WriteLine("{0}->{1}->{2}", ptrRaiz.id, ptrRaiz.n, nodovisitado);
                InOrden(ref ptrRaiz.Derecha, "Derecha");
                
            }
        }

        public void PostOrden(ref Nodo ptrRaiz, string nodovisitado)
        {
            if (ptrRaiz != null)
            {
                PostOrden(ref ptrRaiz.Izquierda, "izquierda");
                PostOrden(ref ptrRaiz.Derecha, "Derecha");
                Console.WriteLine("{0}->{1}->{2}", ptrRaiz.id, ptrRaiz.n, nodovisitado);
               

            }

        }

    }
}
