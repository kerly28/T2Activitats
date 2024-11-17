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
                    Console.WriteLine("El numero no es negatiu");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }
    }
}
