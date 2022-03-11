using System;

namespace Palaciosvettori2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int dimensione = 100;

            int[] vett = new int[dimensione];
            Random generator = new Random();
            for (int i = 0; i < dimensione; i++)
            {
                vett[i] = generator.Next(1, 101);
               
                if(vett[i]>=50)
                {
                    Console.WriteLine($"vett[{i}]={vett[i]}");
                }
            }
            

        }
    }
}
