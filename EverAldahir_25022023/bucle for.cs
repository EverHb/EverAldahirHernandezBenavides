using System;

class Program
{
    static void Main(string[] args) 
    {
        Console.Write("ingresa tu valor inicial: ");
        int inicio = Convert.ToInt32(Console.ReadLine());


        Console.Write("ingresa tu valor final: ");
        int fin = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("los pares de valores entre {0} y {1} son:", inicio, fin);
        for (int i = inicio; i <= fin; i++) 
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
