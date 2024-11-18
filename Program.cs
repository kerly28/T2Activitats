//PRE: L'usuari introdueix un número
using system;
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
//POST: Retorna el valor absolut del nuúmero introduït