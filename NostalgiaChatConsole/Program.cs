using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NostalgiaChatConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the nostalgia chatter...");
            Console.WriteLine();
            Console.WriteLine("**************");
            Console.WriteLine("CHAT START");
            Console.WriteLine("**************");
            Console.WriteLine();
            Console.WriteLine(string.Format("Luis ({0}): Hello!", DateTime.Now.AddYears(-1).ToString("d MMMM yyyy hh:mm")));
            Console.WriteLine(string.Format("Wins ({0}): Hola Chibi!", DateTime.Now.AddYears(-1).AddMinutes(1).ToString("d MMMM yyyy hh:mm")));
            Console.WriteLine();
            Console.WriteLine("**************");
            Console.WriteLine("END");
            Console.WriteLine("**************");
            Console.WriteLine();
            Console.WriteLine("Press any key to end.");
            Console.ReadKey();
        }
    }
}
