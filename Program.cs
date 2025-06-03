namespace Ej2._5
{
    public class Program
    {
        public static void Main()
        {
            int numero, quadrat = 0;            

            try
            {
                Console.WriteLine("Introdueïx un número");
                numero = int.Parse(Console.ReadLine());
                quadrat = Quadrat(numero, quadrat);
                Console.WriteLine($"\nEl quadrat de {numero} és {quadrat}.");
            }
            catch (FormatException)
            {
                Console.WriteLine("El valor introduït no és un número vàlid.");
                return;
            }
        }
        public static int Quadrat(int numero, int quadrat)
        {
            quadrat = numero * numero;
            return quadrat;
        }
    }
}