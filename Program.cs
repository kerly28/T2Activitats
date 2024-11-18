//PRE: L'usuari introdueix un número enter
using System;

namespace Metode
{
    public class Program
    {
        public static int CountDigits(int userNum)
        {
            if (userNum == 0) return 1;

            int numDigits = 0;
            while (userNum > 0)
            {
                numDigits++;
                userNum /= 10; 
            }
            return numDigits;
        }
        public static int SumaEven(int userNum)
        {
            int sumEven = 0;
            while (userNum > 0)
            {
                int digit = userNum % 10;  
                if (digit % 2 == 0)  
                {
                    sumEven += digit;
                }
                userNum /= 10; 
            }
            return sumEven;
        }

        public static int SumaOdd(int userNum)
        {
            int sumOdd = 0;
            while (userNum > 0)
            {
                int digit = userNum % 10;  
                if (digit % 2 != 0) 
                {
                    sumOdd += digit;
                }
                userNum /= 10;  
            }
            return sumOdd;
        }
        public static void Main()
        {
            Console.WriteLine("Introdueix un número:");
            int userNum = Convert.ToInt32(Console.ReadLine());

            // Resultats segons si el dígit és parell o senar
            Console.WriteLine("La suma dels dígits parells és: " + SumaEven(userNum));
            Console.WriteLine("La suma dels dígits senars és: " + SumaOdd(userNum));
        }
    }
}
//POST: El programa retorna la suma dels dígits parells i la suma dels dígits senars del número introduït per l'usuari
