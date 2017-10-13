using System;

namespace HandsOn
{
    class HandsOnVariablesOperatorsExpressionsStatements
    {
        static void Main(string[] args) // Main method demonstrates the use of variables, operators, expressions, and statements
        {
            int x = 3;
            int y = 4;
            int sum = x + y;
            System.Console.WriteLine("Sum of " + x + " and " + y + " is: " + sum);

            int val = 7;
            bool comparison = val == sum;
            System.Console.WriteLine("Are the values of sum and " + val + " equal? " + comparison);

            string text1 = "Hello";
            string text2 = "World";
            string message = text1 + " " + text2;
            System.Console.WriteLine("Message: " + message);
        }
    }
}