using System;
using static System.Console;
using System.Text;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {

            StringBuilder text = new StringBuilder("Cat");
            text.Replace('C', 'R');
            Console.WriteLine(text);

            
            // Use a StringBuilder to efficiently change an original string containing
            // the text "Cat" to a result that has one character changed to produce the
            // result "Rat". Then display that result in the console window.

            int? x;
            x = null;
            Console.WriteLine(x);
            Console.WriteLine(x.HasValue);
            
            x = 42;
            Console.WriteLine(x);
            Console.WriteLine(x.HasValue);

            // Declare a nullable int named x, initialize it to null, and then
            // display it in console output. Then display the boolean value that
            // indicates whether x has a value or not. After that, assign 42 to it
            // and display it again and then display the boolean value again that
            // indicates whether x has a value or not.

            string dateTime = "4 July 1776";
            DateTime aDateTime = Convert.ToDateTime(dateTime);
            Console.WriteLine(aDateTime.Day + "/" + aDateTime.Month + "/" + aDateTime.Year);

            // Declare a DateTime variable named aDateTime, and assign it to the result of
            // converting the string "4 July 1776" to a DateTime object. Then display the result.

            char ch = '7';
            if(Char.IsLetter(ch))
            {
                Console.WriteLine("7 is a letter");
            }
            else
            {
                Console.WriteLine("7 is not a letter");
            }

            // Declare a variable of type char named ch and initialize it with the value '7'.
            // Then test it in an if statement to see if it is a letter or a
            // non-letter character. Display output on the console that indicates
            // whether it is a letter or a non-letter.
            
        }
    }
}
