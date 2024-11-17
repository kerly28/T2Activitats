// PRE: l'usuari introdueix un nombre enter y una potència

using System;

namespace Metode
{
    public class Program
    {

        public static int Potencia(int num, int exp)
        {
            int result = 1;
            for (int i = 0; i < exp; i++)
            {
                result *= num;
            }
            return result;
        }

        public static void Main()
        {
            int num, exp;
            Console.WriteLine("Introdueix un número:");
            try
            {
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introdueix la potencia:");
                exp = Convert.ToInt32(Console.ReadLine());

                int result = Potencia(num, exp);
                Console.WriteLine($"El resultat de {num} elevat a la potencia {exp} és: {result}");

            }

            catch (Exception)
            {
                Console.WriteLine("S'ha produït un error.");
            }
        }
    }
}
// PRECON: es mostra per pantalla el resultat de la potència del nombre introduït per l'usuari