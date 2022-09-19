using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsWithLoopsAndConditionals
{
    internal class Methods
    {
        public static void SeparateMethods()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("------------------------------Next Method----------------------------------------");
            Console.WriteLine();
            Console.WriteLine();
        }
        public static void AllNumbersToThousand()
        {
            for (int i = 1000; i > -1001; i--)
            {                
                Console.WriteLine(i);
            }
        }    
        
        public static void EveryThirdNumber()
        {
            for (int i = 3; i < 1000; i+=3)
            {
                Console.WriteLine(i);
            }
        }

        public static void EqualNumbers()
        {
            Console.Write("Please enter first number: ");
            var num1 = int.Parse(Console.ReadLine());

            Console.Write("Please enter second number: ");
            var num2 = int.Parse(Console.ReadLine());

            var answer = (num1 == num2) ? "These numbers are equal." : "These numbers are not equal.";

            Console.WriteLine(answer);
        }

        public static void OddOrEven()
        {
            Console.WriteLine("Please enter a number:");
            var userInput = int.Parse(Console.ReadLine());

            var answer = (userInput % 2 == 0) ? $"{userInput} is an even number." : $"{userInput} is an odd number.";

            Console.WriteLine(answer);
        }

        public static void PositiveOrNegative()
        {
            Console.WriteLine("Please enter a number:");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput > 0)
            {
                Console.WriteLine($"{userInput} is a positive number.");
            }
            else if(userInput < 0)
            {
                Console.WriteLine($"{userInput} is a negative number.");
            }
            else
            {
                Console.WriteLine($"{userInput} is neither a positive nor a negative number.");
            }
        }

        public static void VotingAge()
        {
            Console.WriteLine("Please enter your age:");
            var userAge = int.Parse(Console.ReadLine());

            var answer = (userAge >= 18) ? "You ARE old enough to vote." : "You are NOT old enough to vote.";

            Console.WriteLine(answer);
        }

        public static void InRange()
        {
            Console.WriteLine("Please enter a number:");
            var userInput = int.Parse(Console.ReadLine());

            var answer = (userInput <= 10 && userInput >= -10) ? $"{userInput} is WITHIN the range of -10 to 10." : $"{userInput} is OUTSIDE the range of -10 to 10.";

            Console.WriteLine(answer);           
        }

        public static void MultiplicationTable()
        {
            Console.Write("Please enter a number: ");
            var userInput = int.Parse(Console.ReadLine());
                        
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(i* userInput);
            }            
        }
    }
}
