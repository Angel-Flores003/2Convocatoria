namespace Ej2._5
{
    public class Program
    {
        public static void Main()
        {
            int[] numeros = new int[10];
            int browser;
            bool match = false;
            try
            {
                Console.WriteLine("Introdueïx 10 números");
                for (int i = 0; i < numeros.Length; i++)
                {
                    Console.Write("Número " + (i + 1) + ": ");
                    numeros[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("\nIntrodueïx el número que vols buscar");
                browser = int.Parse(Console.ReadLine());

                match = BrowseArray(numeros, browser, match);
                Console.WriteLine("\nEl número " + browser + (match ? " es troba a l'array." : " no es troba a l'array."));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        public static bool BrowseArray(int[] numeros, int browser, bool match)
        {
            for (int i = 0; i < 10; i++)
            {
                if (numeros[i] == browser)
                {
                    match = true;
                }
            }
            return match;
        }
    }
}