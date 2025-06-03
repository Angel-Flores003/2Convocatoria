namespace Ej2._5
{
    public class Program
    {
        public static void Main()
        {
            int numero = 0;
            string input;

            while (numero < 1 || numero > 100)
            {
                Console.WriteLine("Introdueïx un número enter entre l'1 i el 100");
                input = Console.ReadLine();

                if (int.TryParse(input, out numero) && numero >= 1 && numero <= 100)
                {
                    Console.WriteLine($"\nNúmero {numero} introduït correctament.");
                    break; // Sortim del bucle
                }
                else
                {
                    Console.Write("\nValor no vàlid. ");
                }

            }
        }
    }
}