using System.Globalization;
using System.Text.RegularExpressions;

namespace Ej2._5
{
    public class Program
    {
        public static void Main()
        {
            string entrada, format;

            Console.WriteLine("Introdueïx una data (dd/MM/yyyy)");
            entrada = Console.ReadLine();

            format = "dd/MM/yyyy";
            CultureInfo culture = CultureInfo.InvariantCulture;

            if (DateTime.TryParseExact(entrada, format, culture, DateTimeStyles.None, out DateTime data))
            {
                // Mostra el dia de la setmana en català
                string diaSetmana = culture.DateTimeFormat.GetDayName(data.DayOfWeek);
                Console.WriteLine($"Data vàlida. Cau en {TraduirDiaCatalà(data.DayOfWeek)}.");
            }
            else
            {
                Console.WriteLine("La data no és vàlida.");
            }
        }
        
        static string TraduirDiaCatalà(DayOfWeek dia)
        {
            return dia switch
            {
                DayOfWeek.Monday => "dilluns",
                DayOfWeek.Tuesday => "dimarts",
                DayOfWeek.Wednesday => "dimecres",
                DayOfWeek.Thursday => "dijous",
                DayOfWeek.Friday => "divendres",
                DayOfWeek.Saturday => "dissabte",
                DayOfWeek.Sunday => "diumenge",
                _ => "desconegut"
            };
        }
    }
}