using System;

namespace PalaciosPasswordGeneratorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Password Generator");
            int[] numeri = new int[10];
            numeri[0] = 1;
            numeri[1] = 2;
            numeri[2] = 3;
            numeri[3] = 4;
            numeri[4] = 5;
            numeri[5] = 6;
            numeri[6] = 7;
            numeri[7] = 8;
            numeri[8] = 9;
            numeri[9] = 10;

            char[] alfabeto = new char[26];
            alfabeto[0] = 'a';
            alfabeto[1] = 'b';
            alfabeto[2] = 'c';
            alfabeto[3] = 'd';
            alfabeto[4] = 'e';
            alfabeto[5] = 'f';
            alfabeto[6] = 'g';
            alfabeto[7] = 'h';
            alfabeto[8] = 'i';
            alfabeto[9] = 'j';
            alfabeto[10] = 'k';
            alfabeto[11] = 'l';
            alfabeto[12] = 'm';
            alfabeto[13] = 'n';
            alfabeto[14] = 'o';
            alfabeto[15] = 'p';
            alfabeto[16] = 'q';
            alfabeto[17] = 'r';
            alfabeto[18] = 's';
            alfabeto[19] = 't';
            alfabeto[20] = 'u';
            alfabeto[21] = 'v';
            alfabeto[22] = 'w';
            alfabeto[23] = 'x';
            alfabeto[24] = 'y';
            alfabeto[25] = 'z';
            


            char[] simbolo = new char[11];
            simbolo[0] = 'ì';
            simbolo[1] = 'è';
            simbolo[2] = '+';
            simbolo[3] = 'ò';
            simbolo[4] = 'à';
            simbolo[5] = '$';
            simbolo[6] = '&';
            simbolo[7] = '£';
            simbolo[8] = '§';
            simbolo[9] = 'ç';
            simbolo[10] = '°';


            Console.WriteLine("Indica la lunghezza della password");
            int lunghezza = Convert.ToInt32(Console.ReadLine());
            string nuovapassword = "";
            Random generatore = new Random();
            for (int i = 0; i < lunghezza; i++)
            {
                int sceltamazzo = generatore.Next(1, 4);
                if (sceltamazzo == 1)
                {
                    int indicecasuale = generatore.Next(1, 26);
                    nuovapassword = nuovapassword + alfabeto[indicecasuale];
                }
                else if (sceltamazzo == 2)
                {
                    int indicenumeri = generatore.Next(1, 10);
                    nuovapassword = nuovapassword + numeri[indicenumeri];
                }
                else if (sceltamazzo == 3)
                {
                    int indicesimboli = generatore.Next(1, 11);
                    nuovapassword = nuovapassword + simbolo[indicesimboli];
                }
            }
            Console.WriteLine("La tua password è:");
            Console.WriteLine(nuovapassword);
        }
    }
}
