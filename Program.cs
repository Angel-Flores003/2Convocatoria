using System.Linq.Expressions;
using System.Runtime.ExceptionServices;

namespace Ej2._5
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numero, avg, parell;
            int[] array = new int[10];

            Console.WriteLine("Introdueïx 10 números");
            for (int i = 0; i < array.Length; i++)
            {
                try
                {
                    Console.WriteLine($"Introdueïx un número enter per a la posició {i + 1}");
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Entrada no vàlida. Si us plau, introdueix un número enter.");
                    i--; // Decrementa i per repetir la iteració actual
                }
            }
            Console.WriteLine("\n");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    Console.WriteLine($"El número {array[i]} és parell");
                }
            }            
            avg = (int)array.Average();
            Console.WriteLine($"La mitjana dels números és {avg}");
        }      
    }
}