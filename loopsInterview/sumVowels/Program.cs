﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var sum = 0;
            for (int i = 0; i < input.Length; i++)
                switch (input[i])
                {
                    case 'a': sum += 1; break;
                    case 'e': sum += 2; break;
                    case 'i': sum += 3; break;
                    case 'o': sum += 4; break;
                    case 'u': sum += 5; break;
                }
            Console.WriteLine("Vowels sum = " + sum);

            Console.ReadKey();
        }
    }
}
