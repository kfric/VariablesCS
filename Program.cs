using System;

namespace VariablesCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C#");

            var numberOfCupsOfCoffee = "1";
            var fullName = "Karl Frick";
            var today = DateTime.Now;

            Console.WriteLine($"{numberOfCupsOfCoffee}, {fullName}, {today}");


            // asking for users name and greeting them

            Console.WriteLine("What is your name? ");
            var userName = Console.ReadLine();

            // if Alice is the user she will be greeted differently
            
            if (userName == "Alice") {
                Console.WriteLine("Hey Alice, it's been a while!");
            } else {

            // but if anyone else generic greeting
            
            var greeting = $"It's a pleasure to meet you, {userName}";
            Console.WriteLine(greeting);
            }


            // asking how old the user is

            Console.WriteLine("How old are you?");
            var age = Console.ReadLine();
            var ageResponse = $"If you are {age}, then you must have been born in 92 or 93";
            Console.WriteLine(ageResponse);

            // asking the user for two number

            Console.WriteLine("Please input a number");
            var firstNumberAsString = Console.ReadLine();
            var secondNumberAsString = Console.ReadLine();

            // coverting string input into numbers

            var firstOperand = double.Parse(firstNumberAsString);
            var secondOperand = double.Parse(secondNumberAsString);

            // we need some space...

            Console.WriteLine("");

            // math

            // adding

            var sum = firstOperand + secondOperand;
            Console.WriteLine($"When you add them together you get {sum}");

            // subtracting

            var difference = secondOperand - firstOperand;
            Console.WriteLine($"When you subract {secondOperand} from the {firstOperand}, you get {difference}");

            // multiply

            var product = firstOperand * secondOperand;
            Console.WriteLine($"When you multiply your numbers you get {product}");

            // division

            var quotient = firstOperand / secondOperand;
            Console.WriteLine($"When you divide {firstOperand} by {secondOperand}, you get {quotient}");

            // find the remainder

            var remainder = firstOperand % secondOperand;
            Console.WriteLine($"When  attemping to dividing {firstOperand} and {secondOperand} you get a remainder of {remainder}");





        }
    }
}
