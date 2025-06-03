namespace Ej2._5
{
    public class Program
    {
        public static void Main()
        {
            int numero;

            try
            {
                Console.WriteLine("Introdueïx un número per veure la taula de multilicació");
                numero = int.Parse(Console.ReadLine());

                TableMultiplicar(numero);
            }
            catch (FormatException)
            {
                Console.WriteLine("El valor introduït no és un número vàlid.");
                return;
            }
        }
        public static void TableMultiplicar(int numero)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }
    }
}