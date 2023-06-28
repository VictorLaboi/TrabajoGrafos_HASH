using ListasSimplementeLigadas;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoGrafos
{
    internal class Lista
    {
        public Nodo nodoInicio;
        
        public Lista(string valor)
        {
            nodoInicio = new Nodo(valor);

        }
        public void AgregarNodo(string valor)
        {
            Nodo nodoActual = nodoInicio;

            while (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;
            }

            Nodo nuevoNodo = new Nodo(valor);

            nodoActual.Siguiente = nuevoNodo;
        }

        public void AgregarArit(Lista vertice)
        {
            AgregarNodo(vertice.nodoInicio.Valor);
        }

        private Nodo BuscarNodo(string dato)
        {

                Nodo nodoBusqueda = nodoInicio;

                while (nodoBusqueda.Siguiente != null)
                {
                    nodoBusqueda = nodoBusqueda.Siguiente;

                    if (nodoBusqueda.Valor == dato)
                    {
                        return nodoBusqueda;
                    }
                }


            return null;
        }
        public List<string> ObtenerNodos()
        {
            List<string> nodos = new List<string>();

            Nodo nodoActual = nodoInicio;

            while (nodoActual != null)
            {
                nodos.Add(nodoActual.Valor);
                nodoActual = nodoActual.Siguiente;
            }

            return nodos;
        }

    }
}
