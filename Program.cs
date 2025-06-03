namespace Ej2._5
{
    public class Program
    {
        public static void Main()
        {
            int x, y;
            double result;

            try
            {               
                Console.WriteLine("Introdueïx un número");
                x = int.Parse(Console.ReadLine());

                Console.WriteLine("Introdueïx un altre número");
                y = int.Parse(Console.ReadLine());
                result = x / y;
                Console.WriteLine($"El resultat de la divisió és: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }                       
        }
    }
}