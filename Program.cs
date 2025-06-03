namespace Ej2._5
{
    public class Program
    {
        public static void Main()
        {
            Random random = new Random();
            int numero = random.Next(1, 51), input, intentes = 0;

            try
            {
                Console.WriteLine("Endevina el número secret entre 1 i 50");
                input = Convert.ToInt32(Console.ReadLine());
                intentes++;

                while (input != numero)
                {
                    if (input < numero)
                    {
                        Console.WriteLine("El número secret és més gran. Torna-ho a intentar.");
                    }
                    else
                    {
                        Console.WriteLine("El número secret és més petit. Torna-ho a intentar.");
                    }
                    Console.WriteLine("Torna a provar");
                    input = Convert.ToInt32(Console.ReadLine());
                    intentes++;
                }

                Console.WriteLine($"Enhorabona! Has endevinat el número secret '{numero}' en {intentes} intents");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}