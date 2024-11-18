//PRE: L'usuari introdueix dos valors enters
using System;

namespace Metode
{
    public class Program
    {
        // Retorna el mínim dels dos números
        public static int Min(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num2;
            }
            else
            {
                return num1;
            }
        }

        // Retorna el màxim dels dos números
        public static int Max(int num1, int num2)
        {
            if (num1 < num2)
            {
                return num2;
            }
            else
            {
                return num1;
            }
        }

        // Mètode principal
        public static void Main()
        {
            const string Msg1 = "Introdueix un número:";
            const string Msg2 = "Introdueix un altre número:";

            Console.WriteLine(Msg1);
            int usernum1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Msg2);
            int usernum2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El valor màxim és: " + Max(usernum1, usernum2));
            Console.WriteLine("El valor mínim és: " + Min(usernum1, usernum2));
        }
    }
}
//POST: El programa retorna el màxim i el mínim dels dos valors introduïts.
