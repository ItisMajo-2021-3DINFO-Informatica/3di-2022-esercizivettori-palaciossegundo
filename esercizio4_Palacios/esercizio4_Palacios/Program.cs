using System;

namespace esercizio4_Palacios
{
    class Program
    {
        static void Main(string[] args)
        {
            const int dimensione = 100;
            int[] numeri = new int[dimensione];
            Random generatore = new Random();
            int min = 4000;
            int max = 0;
           
            for (int i = 0; i < dimensione; i++)
            {
                numeri[i] = generatore.Next(1000, 3000);
                Console.WriteLine($"vett[{i}]={numeri[i]}");
                
            }
            for(int i = 0; i < dimensione; i++)
            {
                if (numeri[i] < min)
                {
                    min = numeri[i];
                }
                if (numeri[i] > max)

                {
                    max = numeri[i];

                }
            }

            Console.WriteLine("Il numero piu piccolo è: " + min );
            Console.WriteLine("Il numero piu grande è: " + max);

        }
    }
}
