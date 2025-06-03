namespace Ej2._5
{
    public class Program
    {
        public static void Main()
        {
            int opcio;
            double temperature = 0;

            try
            {
                Console.WriteLine("Introdueïx la temperatura en graus Celsius");
                temperature = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\n[1] Convertir a Fahrenheit\n" +
                    "[2] Convertir a Kelvin");
                opcio = Convert.ToInt32(Console.ReadLine());

                switch
                    (opcio)
                {
                    case 1:
                        temperature = ConvertToFahrenheit(temperature);
                        Console.WriteLine("Temperatura en Fahrenheit: " + temperature);
                        break;
                    case 2:
                        temperature = ConvertToKelvin(temperature);
                        Console.WriteLine("Temperatura en Kelvin: " + temperature);
                        break;
                    default:
                        Console.WriteLine("Opció no valida");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        public static double ConvertToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
        public static double ConvertToKelvin(double celsius)
        {
            return celsius + 273.15;
        }
    }
}