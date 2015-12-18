using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UriSchemeTest
{
    class Program
    {
        static string ProcessInput(string s)
        {
            // TODO Verify and validate the input 
            // string as appropriate for your application.
            return s;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("UriSchemeTest.exe invoked with the following parameters.\r\n");
            Console.WriteLine("Raw command-line: \n\t" + Environment.CommandLine);

            Console.WriteLine("\n\nArguments:\n");
            foreach (string s in args)
            {
                Console.WriteLine("\t" + ProcessInput(s));
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
