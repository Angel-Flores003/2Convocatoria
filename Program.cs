namespace Ej2._5
{
    public class Program
    {
        public static void Main()
        {
            int suma;
            int[] numeros = new int[5];

            try
            {
                Console.WriteLine("Introdueïx 5 números");
                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"Número {i + 1}: ");
                    numeros[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("\n");
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"El número {numeros[i]} es troba a la possició {i + 1}");
                }

                suma = numeros.Sum();
                Console.WriteLine($"\nLa suma dels números és: {suma}");
            }
            catch (FormatException)
            {
                Console.WriteLine("El valor introduït no és un número vàlid.");
                return;
            }
        }
    }
}