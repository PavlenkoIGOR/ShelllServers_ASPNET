using System.Text;
using System;

namespace ShelllServers_ASPNET
{
    public class Logger
    {
        public static void PrintMessage(Action logMode)
        {
            Console.OutputEncoding = Encoding.Unicode;
            // Запускаем логирование
            Console.WriteLine("Логгер запущен");
            logMode.Invoke();
        }

        // Вывод информационных сообщений
        public static void Info(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        // Вывод предупреждений
        public static void Warning(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        // Вывод сообщений об ошибках
        public static void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
