using System;
using System.Collections.Generic;
using TrabajoGrafos;

namespace ListasSimplementeLigadas
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Lista> Grafo = new List <Lista> ();

            Lista verticeA = new Lista("A");
            Lista verticeB = new Lista("B");
            Lista verticeC = new Lista("C");
            Lista verticeD = new Lista ("C");

            verticeA.AgregarArit(verticeB);
            verticeB.AgregarArit(verticeC);
            verticeC.AgregarArit(verticeD);
            verticeD.AgregarArit(verticeA);
            Hash hashTable = new Hash(Grafo.Count);
        }
    }
}

