using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swick
{
    internal class Clase_Arbol
    {
        public Clase_Arbol() { }

        private Nodo CrearNodos(int valor)
        {
            Nodo nuevo = new Nodo(valor);
            nuevo.izquierda = null;
            nuevo.derecha = null;
            return nuevo;
        }

        public void insertar(ref Nodo raiz,int valor)
        {
            if (arbolvacio(raiz))
            {
                raiz = CrearNodos(valor);

            }
            else if(valor < raiz.valor)
            {
                insertar(ref raiz.izquierda, valor);
            }
            else
            {
                insertar(ref raiz.derecha, valor);
            }
        }

        public void Preorden(Nodo raiz)
        {
            if (raiz == null) return;
            Console.WriteLine(raiz.valor);
            Preorden(raiz.izquierda);
            Preorden(raiz.derecha);

        }

        public void PostOrden(Nodo raiz)
        {
            if (raiz == null) return;
            PostOrden(raiz.izquierda);
            PostOrden(raiz.derecha);
            Console.WriteLine(raiz.valor);

        }

        public void InOrden(Nodo raiz)
        {
            if (raiz == null) return;
            PostOrden(raiz.izquierda);
            Console.WriteLine(raiz.valor);
            PostOrden(raiz.derecha);
            
        }

        private bool arbolvacio(Nodo raiz)
        {
            if (raiz == null) return true;
            return false;
        }

        public int Altura(Nodo raiz)
        {
            if (raiz == null) return -1; // Un árbol vacío tiene altura -1
            return 1 + Math.Max(Altura(raiz.izquierda), Altura(raiz.derecha));
        }

        public int Nivel(Nodo raiz, int valor)
        {
            if (raiz == null) return -1;
            if (raiz.valor == valor) return 0;
            int nivelIzq = Nivel(raiz.izquierda, valor);
            if (nivelIzq != -1) return 1 + nivelIzq;
            int nivelDer = Nivel(raiz.derecha, valor);
            return nivelDer != -1 ? 1 + nivelDer : -1;
        }

    }
}
