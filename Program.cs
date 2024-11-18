//PRE: L'usuari introdueix uns minuts
using system

namespace Metode
{
    public class Program
    {

        public static int Segons(int minuts)
        {
        return minuts * 60;
        }
        public static void Main()
        {
            Console.WriteLine("Introdueix els minuts que vols convertir a segons:");
            int minuts = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Els minuts introduïts són en total {Segons(minuts)} segons");
        }
    }
}
//POST: Es mostra els minuts en segons
