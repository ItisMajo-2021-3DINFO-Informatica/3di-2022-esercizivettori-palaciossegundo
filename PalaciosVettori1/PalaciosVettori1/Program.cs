using System;

namespace PalaciosVettori1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int dimensione = 400;
            
            int[] vett = new int[dimensione];
            Random generator = new Random();
             for (int i = 0; i < dimensione; i++)
             {
                vett[i] = generator.Next(0, 101);
                Console.WriteLine($"vett[{i}]={vett[i]}");
             }
            
        }
    }
}
