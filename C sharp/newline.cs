// C# program to print a new line
using System;
using System.IO;
using System.Text;

namespace IncludeHelp
{
    class Test
    {
        // Main Method 
        static void Main(string[] args)
        {
            //using \n
            Console.WriteLine("Hello\nWorld");
            //using \x0A
            Console.WriteLine("Hello\x0AWorld");
            Console.WriteLine();

            Console.WriteLine("end of the program");

            //hit ENTER to exit the program
            Console.ReadLine();
        }
    }
}
