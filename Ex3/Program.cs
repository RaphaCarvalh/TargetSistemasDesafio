

using System;
using System.Collections.Generic;

class Program {
    static void Main(string[] args) {

        // Exemplo a) 1, 3, 5, 7, ___
        List<int> sequencia = new List<int> {1, 3, 5, 7};
        int proximoValor = sequencia[sequencia.Count - 1] + 2;
        sequencia.Add(proximoValor);
        Console.WriteLine("Sequência A): " + string.Join(", ", sequencia));
        Console.WriteLine($"Valor adicionado a lista: {proximoValor}\n");

          // Exemplo b) 2, 4, 8, 16, 32, 64, ____
        List<int> sequenciaB = new List<int> {2, 4, 8, 16, 32, 64};
        int proximoValorB = sequenciaB[sequenciaB.Count - 1] * 2;
        sequenciaB.Add(proximoValorB);
        Console.WriteLine("Sequência b): " + string.Join(", ", sequenciaB));
        Console.WriteLine($"Valor adicionado a lista: {proximoValorB}\n");

        // Exemplo c) 0, 1, 4, 9, 16, 25, 36, ____
        List<int> sequenciaC = new List<int> {0, 1, 4, 9, 16, 25, 36};
        int proximoValorC = sequenciaC[sequenciaC.Count - 1] + (sequenciaC.Count * 2 - 1);
        sequenciaC.Add(proximoValorC);
        Console.WriteLine("Sequência c): " + string.Join(", ", sequenciaC));
        Console.WriteLine($"Valor adicionado a lista: {proximoValorC}\n");

        // Exemplo d)4, 16, 36, 64, ____
        List<int> sequenciaD = new List<int> {4, 16, 36, 64};
        int proximoValorD = sequenciaD[sequenciaD.Count - 1] + (sequenciaD.Count * 4);
        sequenciaD.Add(proximoValorD);
        Console.WriteLine("Sequência d): " + string.Join(", ", sequenciaD));
        Console.WriteLine($"Valor adicionado a lista: {proximoValorD}\n");

        // Exemplo e)1, 1, 2, 3, 5, 8, ____
        List<int> sequenciaE = new List<int> {1, 1, 2, 3, 5, 8};
        int proximoValorE = sequenciaE[sequenciaE.Count - 1] + sequenciaE[sequenciaE.Count - 2];
        sequenciaE.Add(proximoValorE);
        Console.WriteLine("Sequência e): " + string.Join(", ", sequenciaE));
        Console.WriteLine($"Valor adicionado a lista: {proximoValorE}\n");

        // Exemplo f)2,10, 12, 16, 17, 18, 19, ____
        List<int> sequenciaF = new List<int> {2, 10, 12, 16, 17, 18, 19};
        int proximoValorF = sequenciaF[sequenciaF.Count - 1] + 1;
        sequenciaF.Add(proximoValorF);
        Console.WriteLine("Sequência f): " + string.Join(", ", sequenciaF));
        Console.WriteLine($"Valor adicionado a lista: {proximoValorF}\n");
    }
}