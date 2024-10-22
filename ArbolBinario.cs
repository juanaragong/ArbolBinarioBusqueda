using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinarioBusqueda
{
    internal class ArbolBinario
    {

        public Nodo Raiz { get; set; }

        public ArbolBinario()
        {
            Raiz = null;
        }

        public void Insertar(int valor)
        {
            if (Raiz == null)
            {
                Raiz = new Nodo(valor);
            }
            else
            {
                InsertarRecursivo(Raiz, valor);
            }
        }

        private void InsertarRecursivo(Nodo nodo, int valor)
        {
            if (valor < nodo.Valor)
            {
                if (nodo.Izquierdo == null)
                {
                    nodo.Izquierdo = new Nodo(valor);
                }
                else
                {
                    InsertarRecursivo(nodo.Izquierdo, valor);
                }
            }
            else
            {
                if (nodo.Derecho == null)
                {
                    nodo.Derecho = new Nodo(valor);
                }
                else
                {
                    InsertarRecursivo(nodo.Derecho, valor);
                }
            }
        }

        public void Preorden(Nodo nodo, List<int> recorrido)
        {
            if (nodo != null)
            {
                recorrido.Add(nodo.Valor);
                Preorden(nodo.Izquierdo, recorrido);
                Preorden(nodo.Derecho, recorrido);
            }
        }

        public void Inorden(Nodo nodo, List<int> recorrido)
        {
            if (nodo != null)
            {
                Inorden(nodo.Izquierdo, recorrido);
                recorrido.Add(nodo.Valor);
                Inorden(nodo.Derecho, recorrido);
            }
        }

        public void Postorden(Nodo nodo, List<int> recorrido)
        {
            if (nodo != null)
            {
                Postorden(nodo.Izquierdo, recorrido);
                Postorden(nodo.Derecho, recorrido);
                recorrido.Add(nodo.Valor);
            }

        }

    }
}