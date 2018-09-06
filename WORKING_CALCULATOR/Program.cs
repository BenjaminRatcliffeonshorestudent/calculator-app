using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WORKING_CALCULATOR
{
    class Program
    {
        static void Main(string[] args)
        {
            bool calculatorRunning;
            decimal firstdecimal;
            do
            {
                //User inputs numbers to add/subtract/multiply/divide.

                Console.WriteLine("Please insert first number.");
                firstdecimal = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Please insert second number.");
                decimal seconddecimal = Convert.ToDecimal(Console.ReadLine());
                decimal answer;

                //operations
                Console.WriteLine("What would you like to do today?");
                Console.WriteLine("1) Add \n2) Subtract \n3) Multiply \n4) Divide");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        answer = firstdecimal + seconddecimal;
                        Console.WriteLine("You chose addition.");
                        Console.WriteLine(firstdecimal + " + " + seconddecimal + " = " + answer);
                        break;

                    case "2":
                        answer = firstdecimal - seconddecimal;
                        Console.WriteLine("You chose subtraction.");
                        Console.WriteLine(firstdecimal + " - " + seconddecimal + " = " + answer);
                        break;

                    case "3":
                        answer = firstdecimal * seconddecimal;
                        Console.WriteLine("You chose multiplication.");
                        Console.WriteLine(firstdecimal + " * " + seconddecimal + " = " + answer);
                        break;

                    case "4":
                        answer = firstdecimal / seconddecimal;
                        Console.WriteLine("You chose division.");
                        Console.WriteLine(firstdecimal + " / " + seconddecimal + " = " + answer);
                        break;

                    default:
                        Console.WriteLine("Put in 1-4!!!!!");
                        break;

                }

                Console.WriteLine("Would you like me to calculate again? \n1) Yes \n2) No");
                string loopText = Console.ReadLine();

                if (loopText == "yes" || loopText == "1")
                {
                    calculatorRunning = true;
                }
                else
                {
                    calculatorRunning = false;
                }
            }
            while (calculatorRunning);
            Environment.Exit(0);
        }
    }
}
