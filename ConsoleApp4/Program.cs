using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             This program will generate two random numbers between 2 and 10 
             This program will show the two numbers to the user in the form of 
             numb1 * numb2, and then ask the user for the answer 
             The program needs to check if the user did submit the right answer 
          
             */

            bool ProgramContinue = true;

            while (ProgramContinue == true)

            {
             //Input 
                Random Number1;

                Number1 = new Random();
                //rang not inclusive always add number above bc range is -1 
                int x = Number1.Next(2, 11);

                Random Number2;
                Number2 = new Random();
                //range not inclusive always add number above bc range is -1
                int y = Number2.Next(2, 11);
                Console.WriteLine(x);
                Console.WriteLine(y);

                int product = y * x;
                Console.WriteLine("What is the product of {0},{1}?", x, y);

                int UserInput;
                UserInput = int.Parse(Console.ReadLine());
                Console.WriteLine("You typed" +  UserInput);

                //Processing

                if (UserInput != product)
                {
                    Console.WriteLine("Sorry Wrong Answer Try Again");
                    Console.WriteLine("The Correct Answer is" + product);
                }

                else
                {
                    Console.WriteLine("Great That's the write answer");
                    ProgramContinue = false;
                }
            }
        }













    
        }
    }

