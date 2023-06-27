using ListasSimplementeLigadas;
using System;
using System.Collections.Generic;
using System.Linq;
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
            nodoActual.Siguiente = new Nodo(valor);
        }
        public void AgregarArit(Lista vertices)
        {
            AgregarNodo(vertices.nodoInicio.Valor);
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
