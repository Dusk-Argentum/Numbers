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
            int low = 0, high = 100;

            while(true)
                {
                    int val = r.Next(low,high);
                    Console.WriteLine("Is it {0}?", val);
                    ConsoleKeyInfo key = Console.ReadKey();

                    if (key.KeyChar == 'h')
                    {
                        Console.WriteLine("Higher. HIGHER!");
                        low = val;
                    }
                    else if (key.KeyChar == 'l')
                    {
                        Console.WriteLine("Lower. LOOOOOOOOOOOWER!!!");
                        high = val;
                    }
                    else if (key.KeyChar == 'e')
                    {
                        Console.WriteLine("Correct! Congratulations to me and you suck and I win! You should feel bad for picking a shitty number.  Also you smell and your mother doesn't love you. Additionally, your intelligence is completely pitiful and you need to go back to Kindergarten. Idiot. Baka. Git rekt.");
                        break;
                    }
            }
        }
    }
}