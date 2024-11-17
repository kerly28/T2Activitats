using System;

namespace Metode
{
    public class Program
    {
        public static bool Natural(int numUser)
        {
            return (numUser >= 0);
        }
        public static void Main(string[] args)
        {
            int numUser;
            Console.WriteLine("Introdueix un numero:");
            try
            {
                numUser = Convert.ToInt32(Console.ReadLine());
                if (Natural(numUser))
                {
                    Console.WriteLine("Es natural");
                }
                else
                {
                    Console.WriteLine("No es natural");
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }
    }
}