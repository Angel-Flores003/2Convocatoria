namespace Ej2._5
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numero = 0, factorial = 0, iterativa, recursiva;

            while (numero <= 0)
            {
                try
                {
                    Console.WriteLine("Introdueïx un número enter i positiu per teclat");
                    numero = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Entrada no vàlida. Si us plau, introdueix un número enter.");
                }
            }

            iterativa = Iterativa(numero);
            Console.WriteLine($"De forma iterativa és {iterativa}");
            recursiva = Recursiva(numero);
            Console.WriteLine($"De fomra recursiva és {recursiva}");
        }
        public static int Iterativa(int numero)
        {
            int num = 1;

            for (int i = 1; i <= numero; i++)
            {
                num *= i;
            }
            return num;
        }

        public static int Recursiva(int numero)
        {
            if (numero == 0) return 1;
            return numero * Recursiva(numero - 1);
        }
    }
}