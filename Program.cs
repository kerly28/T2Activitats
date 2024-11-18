//PRE: S'introdueix graus (serà interpretat com a Celsius)
using System;
namespace Metode
{
    public class Program
    {
        public static int ConvertirCelsiusAFahrenheit(int celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
        public static void Main()
        {
            int celsius;
            Console.WriteLine("Introdueix els graus Celsius:");
            try
            {
                celsius = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Els graus en Fahrenheit són: " + ConvertirCelsiusAFahrenheit(celsius));
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }
    }
}
//POST: El programa converteix els graus Celsius introduits en Fahrenheit