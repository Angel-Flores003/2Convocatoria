namespace Ej2._5
{
    public class Program
    {
        public static void Main()
        {
            string[] strings = new string[5];
            string[] stringsreverse = new string[5];
            string[] stringsinvers = new string[5];

            try
            {
                Console.WriteLine("Introdueïx 10 paraulse");
                for (int i = 0; i < strings.Length; i++)
                {
                    Console.Write("Paraula " + (i + 1) + ": ");
                    strings[i] = Console.ReadLine();
                }

                //Canvia l'ordre de les paraules
                for (int i = 0; i < strings.Length; i++)
                {
                    stringsreverse[i] = strings[strings.Length - 1 - i];
                }
                Console.WriteLine("\nLes paraules en ordre invers són:");
                for (int i = 0; i < stringsreverse.Length; i++)
                {
                    Console.WriteLine(stringsreverse[i]);
                }

                //Inverteix les paraules
                for (int i = 0; i < strings.Length; i++)
                {
                    char[] charArray = strings[i].ToCharArray();
                    Array.Reverse(charArray);
                    stringsinvers[i] = new string(charArray);
                }
                Console.WriteLine("\nLes paraules invertides són:");
                for (int i = 0; i < stringsinvers.Length; i++)
                {
                    Console.WriteLine(stringsinvers[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}