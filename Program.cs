namespace Ej2._5
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Introdueix una contrasenya:\n\t " +
                "Entre 8 i 12 caracters\n\t " +
                "Amb una mayuscula una minuscula i un número\n\t " +
                "Sense espais");
            string contrasenya = Console.ReadLine();

            if (ValidarContra(contrasenya))
            {
                Console.WriteLine("La contrasenya és vàlida.");
            }
            else
            {
                Console.WriteLine("La contrasenya no compleix els requisits.");
            }
        }

        static bool ValidarContra(string password)
        {
            if (password.Length < 8 || password.Length > 12) return false;

            bool teMajuscula = false;
            bool teMinuscula = false;
            bool teNumero = false;

            foreach (char c in password)
            {
                if (char.IsWhiteSpace(c)) return false;
                if (char.IsUpper(c)) teMajuscula = true;
                else if (char.IsLower(c)) teMinuscula = true;
                else if (char.IsDigit(c)) teNumero = true;
            }

            return teMajuscula && teMinuscula && teNumero;
        }
    }
}