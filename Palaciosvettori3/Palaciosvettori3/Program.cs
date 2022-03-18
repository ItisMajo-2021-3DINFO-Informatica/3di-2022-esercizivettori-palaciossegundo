using System;

namespace Palaciosvettori3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int dimensione = 30;
            int[] numeri = new int[dimensione];
            int somma = 0;
            Random generatore = new Random();
            
            for ( int i=0;i<dimensione;i++)
            {
                numeri[i] = generatore.Next(0, 51); 
                Console.WriteLine($"vett[{i}]={numeri[i]}");
                 somma = somma + numeri[i];
            }
            int media = somma / 30;
            Console.Write($"La media è = {media}");
        }
    }
}
