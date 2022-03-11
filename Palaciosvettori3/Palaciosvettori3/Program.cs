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
            int i = 0;
            
            for ( i=0;i<dimensione;i++)
            {
                numeri[i] = generatore.Next(1, 51);
                int media = (somma + numeri[i])/2;

            }
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine($"vett[{i}]={numeri[i]}");
            }
            //ciclo di visualizzazione
            for (i = 0; i < 10; i++)
            {
                Console.Write(numeri[i] + "+");

            }
            Console.Write($"La media è =" + {media});
        }
    }
}
