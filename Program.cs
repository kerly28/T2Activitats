//PRE: L'usuari introdueix un nombre decimal
using System;

namespace Metode
{
    public class Program
    {
        // Retorna la part entera del número
        public static int Enter(double usernum)
        {
            return (int)Math.Floor(usernum);
        }

        // Retorna la part decimal del número
        public static double Decimal(double usernum)
        {
            double usernum2 = usernum - Math.Floor(usernum);
            return Math.Round(usernum2, 2);
        }

        // Mètode principal
        public static void Main()
        {
            try
            {
                Console.WriteLine("Introdueix un número decimal:");
                double usernum = Convert.ToDouble(Console.ReadLine()); // Llegim un número decimal

                Console.WriteLine($"La part entera és: {Enter(usernum)} i la part decimal és: {Decimal(usernum)}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: No has introduït un número decimal vàlid.");
            }
        }
    }
}
//POST: El programa retorna la part entera i la part decimal
