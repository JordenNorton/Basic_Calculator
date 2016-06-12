using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start of program ---
            Console.WriteLine("Basic Calculator V1.0");
            Console.WriteLine();

            //Variables ---
            int firstNum;
            int secondNum;
            int chosenOperator;


            //Ask for first value ---
            Console.WriteLine("Please enter your first number");
            firstNum = Convert.ToInt32(Console.ReadLine());

            //Ask for second value ---
            Console.WriteLine("Please enter your second number");
            secondNum = Convert.ToInt32(Console.ReadLine());

            //Ask for operator ---
            Console.WriteLine("Press 1 for +");
            Console.WriteLine("Press 2 for -");
            Console.WriteLine("Press 3 for *");
            Console.WriteLine("Press 4 for /");

            chosenOperator = Convert.ToInt32(Console.ReadLine());

            //Calculation ---
            switch (chosenOperator)
            {
                case 1:
                    Console.WriteLine("{0} + {1} = {2}",firstNum, secondNum, firstNum + secondNum);
                    break;
                case 2:
                    Console.WriteLine("{0} - {1} = {2}", firstNum, secondNum, firstNum - secondNum);
                    break;
                case 3:
                    Console.WriteLine("{0} * {1} = {2}", firstNum, secondNum, firstNum * secondNum);
                    break;
                case 4:
                    Console.WriteLine("{0} / {1} = {2}", firstNum, secondNum, firstNum / secondNum);
                    break;

            }

            //End of program ---
            Console.WriteLine();
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();  
        }
    }
}
