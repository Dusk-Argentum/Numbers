using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            Random r = new Random();

            Console.WriteLine("Think of a number between 0 and 100.");
            while(true)
                {
                    while (true)
                    {
                        int val = r.Next(0, 100);
                    }
                    Console.Write("Is it {0}?", val);
                    ConsoleKeyInfo key = Console.ReadKey();

                    if (key.KeyChar == 'h')
                    {
                        Console.Write("Higher. HIGHER!");
                    }
                    else if (key.KeyChar == 'l')
                    {
                        Console.Write("Lower. LOOOOOOOOOOOWER!!!");
                    }
                    else if (key.KeyChar == 'e')
                    {
                        Console.WriteLine("Correct! Congratulations to me and you suck and I win! You should feel bad for picking a shitty number.  Also you smell and your mother doesn't love you.");
                        break;
                    }
            }
        }
    }
}
