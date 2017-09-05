using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printASCIICharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Latin alphabet:");
            for (char letter = 'z'; letter >= 'a'; letter--)
            {
                Console.WriteLine(" " + letter); //Prints ASCII symbols from 'z' to 'a' - inverse order
            }
            Console.ReadKey();
        }
    }
}
