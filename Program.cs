//PRE: L'usuari introdueix un numero
using System;

namespace Metode
{
    public class Program
    {
        public static bool Negatiu(int num)
        {
            return num < 0;
        }
        public static void Main()
        {
            int num;
            Console.WriteLine("Introdueix un numero");

            try
            {
                num = Convert.ToInt32(Console.ReadLine());
                if (Negatiu(num))
                {
                    Console.WriteLine("El numero si es negatiu");
                }
                else
                {
                    Console.WriteLine("El numero no és negatiu");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }
    }
}
//POST: El programa diu si el numero es negatiu o no