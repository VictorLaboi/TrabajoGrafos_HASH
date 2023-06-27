using System;
using System.Collections.Generic;
using TrabajoGrafos;

namespace ListasSimplementeLigadas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Lista> Grafo = new List<Lista>();

            Lista vertA = new Lista("A");
            Lista vertB = new Lista("B");
            Lista vertC = new Lista("C");
            Lista vertD = new Lista("D");

            vertA.AgregarArit(vertB);
            vertA.AgregarArit(vertC);
            vertB.AgregarArit(vertD);
            Grafo.Add(vertA);
            Grafo.Add(vertB);
            Grafo.Add(vertC);
            Grafo.Add(vertD);
            Hash hastTable = new Hash();
            Console.ReadKey();
        }
    }
}

