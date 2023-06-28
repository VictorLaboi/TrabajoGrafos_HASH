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
        public List<(string, string)> relaciones;
        public Lista()
        {
            relaciones = new List<(string, string)>();
            nodoInicio = new Nodo();
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
        public void AgregarNodoInicio(string valor)
        {
            Nodo nodoActual = nodoInicio;
            Nodo nuevoNodo = new Nodo(valor, nodoActual.Siguiente);
            nodoActual.Siguiente = nuevoNodo;
        }
        public void AgregarArit(String inicio, string final)
        {
            Nodo nodoActual = nodoInicio;
            Nodo nodoInicial = BuscarNodo(inicio);
            Nodo nodoFinal = BuscarNodo(final);
            if (nodoInicial!=null && nodoFinal!= null) {
                nodoInicial.Siguiente = nodoFinal;
                nodoFinal.Siguiente = nodoInicial;
                relaciones.Add((inicio, final));
            }
            else
            {
                Console.Write("NODO NO ENCONTRADO!");
            }
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
        public void MostrarGrafo()
        {
            foreach ((string inicio, string final) in relaciones)
            {
                Console.WriteLine($"{inicio} --> {final}");
            }
        }

    }
}
