using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool RunProgram = true;
            bool GetInput = true;
            int Input = 0;
            while (RunProgram)
            {
                //input
                Console.WriteLine("Please enter your name.");                
                string Name = Console.ReadLine();
                Console.WriteLine("Hi, {0}.", Name);

                while (GetInput)
                {
                    Console.WriteLine("Enter a number between 1 and 100.");
                    string num1 = Console.ReadLine();
                    
                    if (int.TryParse(num1, out Input))
                    {
                        Console.Clear();
                        GetInput = false;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Oops. You entered {0}.", num1);                        
                    }
                }
                //process

                if (Input % 2 != 0)
                {
                    Console.WriteLine("{0} is odd, {1}", Input, Name);
                }
                else if (Input % 2 == 0 && Input >= 2 && Input <= 25)
                {
                    Console.WriteLine("{0} is even and less than 25, {1}", Input, Name);
                }
                else if (Input % 2 == 0 && Input >= 26 && Input <= 60)
                {
                    Console.WriteLine("{0} is even, {1}", Input, Name);
                }
                else if (Input % 2 == 0 && Input > 60)
                {
                    Console.WriteLine("{0} is even, {1}", Input, Name);
                }
                Console.WriteLine("Run again (Y/N)?");
                char DoAgain = char.Parse(Console.ReadLine());

                if (DoAgain == 'y' || DoAgain == 'Y')
                {
                    RunProgram = true;
                    GetInput = true;
                    Console.Clear();
                }
                else
                {
                    RunProgram = false;
                }
            }
        }
    }
}

