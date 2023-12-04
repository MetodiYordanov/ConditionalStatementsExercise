namespace Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This is a program that reads two integers (N1 and N2) along
            // with an operator to perform a mathematical operation between them.
            // Example - Input: first number = 10, second number = 12, operator is "+",
            // Output: 10 + 12 = 22 - even

            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            string operatorForOutput = Console.ReadLine();
            
            double result = 0;
            string evenOrOdd = string.Empty;

            if (operatorForOutput == "+") 
            {
                result = firstNumber + secondNumber;
            }
            else if (operatorForOutput == "-")
            {
                result = firstNumber - secondNumber;
            }
            else if (operatorForOutput == "*")
            {
                result = firstNumber * secondNumber;
            }
            else if (operatorForOutput == "/")
            {
                if (secondNumber == 0)
                {
                    Console.WriteLine($"\nCannot divide {firstNumber} by zero");
                    return;
                }
                result = (double) firstNumber / secondNumber;
            }
            else if (operatorForOutput == "%")
            {
                if (secondNumber == 0)
                {
                    Console.WriteLine($"\nCannot divide {firstNumber} by zero");
                    return;
                }
                result = firstNumber % secondNumber;
            }

            if (operatorForOutput == "+" || operatorForOutput == "-" || operatorForOutput == "*")
            {
                if (result % 2 == 0)
                {
                    evenOrOdd = "even";
                }
                else
                {
                    evenOrOdd = "odd";
                }
            }

            if (evenOrOdd == string.Empty)
            {
                Console.WriteLine($"\n{firstNumber} {operatorForOutput} {secondNumber} = {result}");
            }
            else
            {
                Console.WriteLine($"\n{firstNumber} {operatorForOutput} {secondNumber} = {result} - {evenOrOdd}");
            }
        }
    }
}