using ListasSimplementeLigadas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoGrafos
{
    internal class Hash
    {
        private Nodo[] stuffs;
        private int tam;

        public Hash(int tam) {
            this.tam = tam;
            stuffs = new Nodo[tam];
        }

        private int HashFunction(string oem) {
            int k_ey = oem.GetHashCode();
            int posit = Math.Abs(k_ey);
            return posit;
        }
        public void Add(string oem, string datos)
        {
            int posit = HashFunction(oem);
            if (stuffs[posit] == null)
            {
                Nodo nodoNuevo = new Nodo(datos);
                stuffs[posit] = nodoNuevo;
            }
            else {
                Nodo nodoNo = stuffs[posit];
                while (nodoNo.Siguiente!= null) {
                    nodoNo = nodoNo.Siguiente;
                }
                Nodo newNode = new Nodo(datos);
                nodoNo.Siguiente = newNode;
            }

        }
        public void MostrarTablaHash()
        {
            for (int i = 0; i < tam; i++)
            {
                Console.Write($"Índice {i}: ");

                Nodo nodo = stuffs[i];
                if (nodo != null)
                {
                    Console.Write($"{nodo.Valor}");

                    if (nodo.Siguiente != null)
                    {
                        
                        Console.Write(" -> ");
                        Nodo Enlace = nodo.Siguiente;
                        while (Enlace!= null ) {
                            Console.Write($"{Enlace.Valor} ");
                            Enlace = Enlace.Siguiente;
                        }
                        
                    }
                }
                else
                {
                    Console.Write("Vacío");
                }
                Console.WriteLine();
            }
        }

    }
}
