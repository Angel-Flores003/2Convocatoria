namespace Ej2._5
{
    public class Program
    {
        public static void Main()
        {
            int[] numeros = new int[8];

            try
            {
                Console.WriteLine("Introdueïx 8 números:");
                for (int i = 0; i < 8; i++)
                {
                    Console.Write($"Introdueïx el número de la possició {i + 1}: ");
                    numeros[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("\n");
                Maxnum(numeros);
                Minnum(numeros);
                Avgnum(numeros);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        public static void Maxnum(int[] numeros)
        {
            int max = numeros[0];
            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] > max)
                {
                    max = numeros[i];
                }
            }
            Console.WriteLine("El número màxim és: " + max);
        }
        public static void Minnum(int[] numeros)
        {
            int min = numeros[0];
            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] < min)
                {
                    min = numeros[i];
                }
            }
            Console.WriteLine("El número mínim és: " + min);
        }
        public static void Avgnum(int[] numeros)
        {
            double sum = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                sum += numeros[i];
            }
            double avg = sum / numeros.Length;
            Console.WriteLine("La mitjana dels números és: " + avg);
        }
    }
}