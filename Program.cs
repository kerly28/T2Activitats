//PRE: L'usuari introdueix un número

using System;

namespace Metode
{
    public class Program
    {
        public static double ValorAbsolut(double usernum)
        {
            if (usernum < 0)
            {
                usernum = -usernum;
            }
            return usernum;
        }

        public static void Main()
        {

            Console.WriteLine("Introdueix un número:");
            double usernum = Convert.ToDouble(Console.ReadLine());
            double resultat = ValorAbsolut(usernum);
            Console.WriteLine($"El valor absolut de {usernum} és {resultat}");
        }
    }
}
//POST: El programa retorna el valor absolut del número introduït per l'usuari