using System;
public class NumeroReal
{
    public static void Main()
    {

        Num();

    }
    public static void Num()
    {

        bool compro = false;

        for (int i = 3; i > 0 && compro == false; i--)
        {
            Console.WriteLine("Introdueix un número");
            int s = Convert.ToInt32(Console.ReadLine());

            if (s > 0)
            {
                Console.WriteLine("És un número real");
                compro = true;
            }
            if (s < 0)
            {

                Console.WriteLine($" El número no es real, té {i - 1} intents");

            }
        }
        if (!compro)
        {
            Console.WriteLine("T'has quedat sense intents");
        }
    }
}
