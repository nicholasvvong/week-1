using System;
/*
a user should be able to enter the starting and ending count
a user should be able to enter these values in any order
a user should be able to get the number of times fizz, buzz and fizzbuzz appear
a user should be able to set new values for fizz, buzz and fizzbuzz
*/
namespace FizzBuzzy
{
    internal class Fizzy
    {
        private const String _fizz = "Fizz";
        private const String _buzz = "Buzz";
        private const String _fizzbuzz = "FizzBuzz";
        public static void Main(string[]   args)
        {
            var f = new Fizzy();
            f.GetStartEnd();
        }

        private int GetIntInput()
        {
            bool correctInput = false;
            var userInput = "";
            var intUserInput = 0;
            Console.Write("Enter Number: ");
            do{
                userInput = Console.ReadLine();
                if(int.TryParse(userInput, out intUserInput))
                {
                    correctInput = true;
                }
                else
                {
                    Console.WriteLine("Invalud Input. Require Integer.");
                }
            }while(!correctInput);

            return intUserInput;
        }

        private void GetStartEnd()
        {
            var firstNum = GetIntInput();
            var secondNum = GetIntInput();

            if(firstNum < secondNum)
            {
                FizzBuzz(firstNum, secondNum);
            }
            else
            {
                FizzBuzz(secondNum, firstNum);
            }
        }

        private void FizzBuzz(int start, int end)
        {
            var fizzValue = GetIntInput();
            var buzzValue = GetIntInput();

            for (int i = start; i <= end; i += 1)
            {
                if(i % fizzValue == 0 && i % buzzValue == 0)
                {
                    Console.WriteLine(_fizzbuzz);
                }
                else if(i % fizzValue == 0)
                {
                    Console.WriteLine(_fizz);
                }
                else if(i % buzzValue == 0)
                {
                    Console.WriteLine(_buzz);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}