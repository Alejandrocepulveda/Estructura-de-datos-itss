using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario3
{
    public class Nodo
    {
        public int valor;
        public Nodo izquierda;
        public Nodo derecha;

        public Nodo(int val)
        {
            valor = val;
            izquierda = null;
            derecha = null;
        }
    }

    internal class ArbolBinario
    {
        public Nodo raiz;

        public ArbolBinario()
        {
            raiz = null;
        }

        public void Insertar(int valor)
        {
            raiz = InsertarRec(raiz, valor);
        }

        public Nodo InsertarRec(Nodo raiz, int valor)
        {
            if (raiz == null)
            {
                raiz = new Nodo(valor);
                return raiz;
            }

            if (valor < raiz.valor)
            {
                raiz.izquierda = InsertarRec(raiz.izquierda, valor);
            }
            else if (valor > raiz.valor)
            {
                raiz.derecha = InsertarRec(raiz.derecha, valor);
            }

            return raiz;
        }

        public int AlturaArbol(Nodo nodo)
        {
            if (nodo == null)
                return 0;
            else
            {
                int izquierda = AlturaArbol(nodo.izquierda);
                int derecha = AlturaArbol(nodo.derecha);

                if (izquierda > derecha)
                    return (izquierda + 1);
                else
                    return (derecha + 1);
            }
        }

        public int CantidadNodos(Nodo nodo)
        {
            if (nodo == null)
                return 0;
            else
                return 1 + CantidadNodos(nodo.izquierda) + CantidadNodos(nodo.derecha);
        }

        public void RecorridoEnAmplitud()
        {
            Console.WriteLine("Recorrido en Amplitud:");
            int altura = AlturaArbol(raiz);
            for (int i = 1; i <= altura; i++)
            {
                ImprimirNivel(raiz, i);
            }
        }

        public void ImprimirNivel(Nodo nodo, int nivel)
        {
            if (nodo == null)
                return;
            if (nivel == 1)
                Console.Write(nodo.valor + " ");
            else if (nivel > 1)
            {
                ImprimirNivel(nodo.izquierda, nivel - 1);
                ImprimirNivel(nodo.derecha, nivel - 1);
            }
        }

        public void RecorridoPreOrden(Nodo nodo)
        {
            if (nodo != null)
            {
                Console.Write(nodo.valor + " ");
                RecorridoPreOrden(nodo.izquierda);
                RecorridoPreOrden(nodo.derecha);
            }
        }

        public void RecorridoInOrden(Nodo nodo)
        {
            if (nodo != null)
            {
                RecorridoInOrden(nodo.izquierda);
                Console.Write(nodo.valor + " ");
                RecorridoInOrden(nodo.derecha);
            }
        }

        public void RecorridoPostOrden(Nodo nodo)
        {
            if (nodo != null)
            {
                RecorridoPostOrden(nodo.izquierda);
                RecorridoPostOrden(nodo.derecha);
                Console.Write(nodo.valor + " ");
            }
        }
    }
}