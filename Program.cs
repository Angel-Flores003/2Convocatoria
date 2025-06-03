namespace Ej2._5
{
    public class Program
    {
        public static void Main()
        {
            int numero;

            try
            {
                Console.WriteLine("Introdueïx un número");
                numero = int.Parse(Console.ReadLine());

                PosNegZero(numero);
                ParellSenar(numero);
            }
            catch (FormatException)
            {
                Console.WriteLine("El valor introduït no és un número vàlid.");
                return;
            }
        }   
        public static void PosNegZero(int numero)
        {
            if (numero > 0)
            {
                Console.WriteLine("El número és positiu.");
            }
            else if (numero < 0)
            {
                Console.WriteLine("El número és negatiu.");
            }
            else
            {
                Console.WriteLine("El número és zero.");
            }
        }
        public static void ParellSenar(int numero)
        {
            if (numero % 2 == 0)
            {
                Console.WriteLine("El número és parell.");
            }
            else
            {
                Console.WriteLine("El número és senar.");
            }
        }
    }
}