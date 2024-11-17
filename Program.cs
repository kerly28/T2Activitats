//PRE: L'usuari introdueix un número
using System;

namespace Metode
{
    public class Program
    {
        public static bool PositiveRank(int num)
        {
            return (num > 0 && num < 100);
        }

        public static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Introdueix un número:");
            try
            {
                num = Convert.ToInt32(Console.ReadLine());

                if (PositiveRank(num))
                {
                    Console.WriteLine("El numero es positiu i menor a 100");
                }
                else
                {
                    Console.WriteLine("El numero no es un nombre vàlid");
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Error");

            }
        }
    }
}
//POST: El programa retorna si el número és positiu i menor a 100
