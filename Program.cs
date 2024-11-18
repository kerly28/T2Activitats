
//PRE: L'usuari introdueix dos valors enters
using system
namespace Metode
{
    public class Program
    {
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public static void Main(string[] args)

        {
            Console.WriteLine("Introdueix el primer valor:");
            int valor1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introdueix el segon valor:");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            Swap(ref valor1, ref valor2);
            Console.WriteLine($"Valors intercanviats: valor1= {valor1}, valor2= {valor2}");
        }
    }
}
//POST: El programa intercanvia els valors introduits per l'usuari


