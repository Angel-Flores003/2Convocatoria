using System.Linq.Expressions;
using System.Runtime.ExceptionServices;

namespace Ej2._5
{
    public class Program
    {
        public void Main(string[] args)
        {
            do
            {
                PrintMenu();
            } while (!ChooseOption());
        }
        public void PrintMenu()
        {
            Console.WriteLine("[1] Calcular àrea d’un rectangle\n" +
                "[2] Mostrar si un any és de traspàs\n" +
                "[3] Sortir del programa");
        }
        public bool ChooseOption()
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
            return false;
        }
        public void Rectangle()
        {
            double width, height;

            Console.WriteLine("Introdueix l'amplada del rectangle:");
            width = double.Parse(Console.ReadLine());

            Console.WriteLine("Introdueix l'alçada del rectangle:");
            height = double.Parse(Console.ReadLine());

            Console.WriteLine($"L'àrea del rectangle és: {width * height}");
        }

        public void Traspas()
        {
            int year = int.Parse(Console.ReadLine());
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