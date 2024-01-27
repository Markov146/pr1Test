using ConsoleApp42;
using System;
using System.Text.RegularExpressions;


class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Введите пароль:");
            string password = Console.ReadLine();
            PasswordValidator validator = new PasswordValidator();
            int score = validator.VerifyPassword(password);

            if (score == 5)
            {
                Console.WriteLine($"Пароль удовлетворяет всем критериям безопасности. Баллы: {score}");
                break;
            }
            else
            {
                Console.WriteLine($"Пароль не удовлетворяет всем критериям безопасности. Баллы: {score}");
                Console.WriteLine("Попробуйте снова");
            }
        }
    }
}
