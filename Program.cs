//PRE: L'usuari introdueix una frase
//POST: El programa retorna la frase en majúscules si l'usuari la introdueix en minúscules i viceversa

using System;

namespace Metode
{
    public class Program
    {
        public static string Upper(string s)
        {
            return s.ToUpper();

        }
        public static string Lower(string s)
        {
            return s.ToLower();
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Introdueix una frase:");
            string user = Console.ReadLine();

            if (user == user.ToUpper())
            {
                Console.WriteLine($"Retorn en minúscules: {user.ToLower()}");
            }
            else
            {
                Console.WriteLine($"Retorn en majúscules: {user.ToUpper()}");
            }


        }
    }

}