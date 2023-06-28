using System;
using System.Collections.Generic;
using TrabajoGrafos;

namespace ListasSimplementeLigadas
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();
            lista.AgregarNodo("nodo1");
            lista.AgregarNodo("nodo2");
            lista.AgregarNodo("nodo3");
            lista.AgregarNodo("nodo4");

            lista.AgregarArit("nodo1", "nodo2");
            lista.AgregarArit("nodo2", "nodo3");
            lista.AgregarArit("nodo3", "nodo4");
            lista.AgregarArit("nodo4", "nodo1");
            lista.MostrarGrafo();
            Console.ReadKey();
        }
    }
}

