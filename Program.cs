using System.Text.RegularExpressions;

namespace Ej2._5
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Introdueix la cadena de 8 dígits seguits d’una lletra: ");
            string entrada = Console.ReadLine();

            if (EsFormatValid(entrada))
            {
                Console.WriteLine("La cadena té el format correcte.");
            }
            else
            {
                Console.WriteLine("Format incorrecte.");
            }
        }

        static bool EsFormatValid(string text)
        {
            // ^ → inici de cadena
            // \d{8} → exactament 8 dígits
            // [A-Za-z] → una lletra (majúscula o minúscula)
            // $ → final de cadena
            return Regex.IsMatch(text, @"^\d{8}[A-Za-z]$");
        }
    }
}