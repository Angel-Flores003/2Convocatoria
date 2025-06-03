namespace Ej2._5
{
    public class Program
    {
        public static void Main()
        {            
            do
            {
                PrintMenu();
            } while (!ChooseOption());
        }
        public static void PrintMenu()
        {
            Console.WriteLine("[1] Calcular àrea d’un rectangle\n" +
                "[2] Mostrar si un any és de traspàs\n" +
                "[3] Sortir del programa");
        }
        public static bool ChooseOption()
        {
            bool isValidateOption;
            do
            {
                isValidateOption = true;
                switch (Console.ReadLine())
                {
                    case "1":
                        Rectangle();
                        break;
                    case "2":
                        Traspas();
                        break;
                    case "3":
                        return true;
                    default:
                        Console.WriteLine("Opció no vàlida. Si us plau, tria una opció vàlida.");
                        isValidateOption = false;
                        break;
                }
            } while (!isValidateOption);
            Console.WriteLine("\nPresiona qualsevol tecla per tornar al menú");
            Console.ReadKey();
            Console.Clear();
            return false;
        }
                public static void Rectangle()
        {
            double width, height;

            Console.WriteLine("Introdueix l'amplada del rectangle:");
            width = double.Parse(Console.ReadLine());

            Console.WriteLine("Introdueix l'alçada del rectangle:");
            height = double.Parse(Console.ReadLine());

            Console.WriteLine($"L'àrea del rectangle és: {width * height}");
        }

        public static void Traspas()
        {
            int year;

            Console.WriteLine("Introdueïx l'any");
            year = int.Parse(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine($"{year} és un any de traspàs.");
            }
            else
            {
                Console.WriteLine($"{year} no és un any de traspàs.");
            }
        }
    }
}