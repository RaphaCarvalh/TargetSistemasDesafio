using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine();
        char[] caracteres = frase.ToCharArray();
        int tamanho = caracteres.Length;

        for (int i = 0; i < tamanho / 2; i++) {
            char temp = caracteres[i];
            caracteres[i] = caracteres[tamanho - i - 1];
            caracteres[tamanho - i - 1] = temp;
        }

        string fraseInvertida = new string(caracteres);
        Console.WriteLine("Frase invertida: " + fraseInvertida);
    }
}