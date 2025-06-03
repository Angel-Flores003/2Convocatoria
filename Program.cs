namespace Ej2._5
{
    public class Program
    {
        public static void Main()
        {
            int numero;
            string input;

            try
            {
                Console.WriteLine("Introdueïx un número enter");
                input = Console.ReadLine();

                if (int.TryParse(input, out numero))
                {
                    int suma = SumaDigits(Math.Abs(numero)); // Usem valor absolut per evitar signes negatius
                    Console.WriteLine("\nLa suma dels seus digits és: " + suma);
                }
                else
                {
                    Console.WriteLine("Entrada no vàlida. Introdueix un número enter.");
                }
            }    
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        static int SumaDigits(int n)
        {
            int suma = 0;
            while (n > 0)
            {
                suma += n % 10; // Afegeix l'últim dígit
                n /= 10;         // Elimina l'últim dígit
            }
            return suma;
        }    
    }
}