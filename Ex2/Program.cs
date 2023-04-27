using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine($"Indique um valor para checagem");
        int num = int.Parse(Console.ReadLine()); 

        bool pertence = false; 
        int a = 0; 
        int b = 1; 

        while (b <= num) 
        {
            if (b == num) 
            {
                pertence = true;
                break;
            }

            int temp = a + b; 
            a = b; 
            b = temp; 
        }

        if (pertence)
        {
            Console.WriteLine($"{num} pertence à sequência de Fibonacci");
        }
        else
        {
            Console.WriteLine($"{num} não pertence à sequência de Fibonacci");
        }
    }
}