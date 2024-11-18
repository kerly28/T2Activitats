//PRE: L'usuari introdueix un any
using System;

namespace Metode
{
    public class Program
    {
        public static bool Traspas(int age)
        {
            return age % 4 == 0;
        }
        public static void Main()
        {
            Console.WriteLine("Introdueix un any:");
            int useryear;
            useryear = Convert.ToInt32(Console.ReadLine());
            if (Traspas(useryear))
            {
                Console.WriteLine("És un any de traspàs");
            }
            else
            {
                Console.WriteLine("No és un any de traspàs");
            }
        }
    }
}
//POST: L'any introduït s'informa si és any de traspàs o no