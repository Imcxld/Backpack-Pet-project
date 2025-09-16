using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backpack.Core
{
    public static class Logger
    {
        public static void Print(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nSystem -> " + message + "\n");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void PrintSuccess(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nSystem -> " + message + "\n");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void PrintError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nSystem -> " + message + "\n");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void PrintCriticalError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nSystem -> " + message + "\n");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void PrintEventNotification(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nNotification handler -> " + message + "\n");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
