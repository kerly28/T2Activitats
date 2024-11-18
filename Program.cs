//PRE: L'usuari ha d'introduir quants valors vol introduïr hi ha de estar entre 15 i 100
using System;

namespace Metode
{
    public class Program
    {        
      // Mètode per introduir un valor
        public static int Value(int num)
        {
            Console.Write("Introdueix quants valors vols introduïr: ");
            int value = Convert.ToInt32(Console.ReadLine());
            return value;
        }

        // Mètode per llegir un valor dins del rang especificat
        public static int? LlegirValor()
        {
            Console.Write("Introdueix un valor entre 15 i 100: ");
            if (int.TryParse(Console.ReadLine(), out int valor) && valor >= 15 && valor <= 100)
            {
                return valor;
            }
            Console.WriteLine("Valor invàlid. Torna a intentar.");
            return null;
        }

        // Mètode per calcular el producte d'una llista de valors
        public static int CalcularProducte(List<int> valors)
        {
            int producte = 1;
            foreach (int valor in valors)
            {
                producte *= valor;
            }
            return producte;
        }

        // Mètode principal
        public static void Main()
        {
            int intentsMaxims = 5;
            int intentsFallits = 0;

            // Utilitzar el mètode `Value` per demanar quants valors vol introduir l'usuari
            int numValors = Value(0);
            if (numValors < 1)
            {
                Console.WriteLine("Nombre de valors invàlid");
                return;
            }

            List<int> valors = new List<int>();

            // Bucle per recollir els valors
            while (valors.Count < numValors && intentsFallits < intentsMaxims)
            {
                int? valor = LlegirValor();

                if (valor.HasValue)
                {
                    valors.Add(valor.Value);
                    intentsFallits = 0; // Restablir intents fallits després d'un valor vàlid
                }
                else
                {
                    intentsFallits++;
                    Console.WriteLine($"Intent fallit {intentsFallits} de {intentsMaxims}.");
                }
            }

            // Mostrar el resultat
            if (valors.Count > 0)
            {
                int producte = CalcularProducte(valors);
                Console.WriteLine($"El producte dels valors introduïts són: {producte}");
            }
        }
    }
}
//POST: El programa mostrarà el producte dels valors introduïts per l'usuari

