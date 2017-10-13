using System;
using static System.Console;
using System.Threading;
using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;

namespace OverloadingGenericsLinqAlgorithms
{
    public class Overloading
    {
        // Implement two overloaded methods named Display.
        // The first overloaded version takes a single parameter of type
        // int and displays that parameter in the console output.
        // The second overloaded version takes a single parameter of type
        // string and displays that parameter in the console output.

        public void Display(int integer)
        {
            WriteLine($"Display int: {integer}");
        }

        public void Display(string str)
        {
            WriteLine($"Display string: {str}");
        }

    }

    class IndexerProperty
    {
        // Implement a read-only indexer property that simply
        // returns the string representation of its int type index value.

        // SKIPPED BY MENTOR'S PERMISSION
    }

    class Generics
    {
        // Implement a generic method named GenericSwapMethod that takes
        // two parameters of any type and swaps them in a persistent way.

        public void GenericSwapMethod<T>(T x, T y)
        {
            T temp;
            temp = x;
            x = y;
            y = temp;
        }

    }

    class Linq
    {
        static public void DisplayEvens(int [] numbers)
        {
            // Google for examples on using LINQ query syntax and then
            // implement a LINQ query that selects only those elements
            // in the int array parameter named numbers, and then display
            // the results of the that query in the console output from
            // within a foreach loop.

            IEnumerable<int> query = from num in numbers
                                    where num % 2 == 0
                                    select num;

            foreach (int i in query)
            {
                WriteLine(i);
            }

        }
    }

    class Gauss
    {
        static public int AddIntegersFromOneUpTo(int limit)
        {
            // Google for a description of "Gauss sum of integers"
            // Then implement that algorithm here and return the result.

            int n = limit;
            int answer = (n*(n+1))/2;
            return answer;
        }
    }

    class Program
    {
        static void Main()
        {
            // Call the two overloaded versions of the Display method.
            // The first call passes in the int value of 42.
            // The second call passes in the string value of "Hello Overloading".

            Overloading ovInt = new Overloading();
             
             int number = 42;
             ovInt.Display(number);
             string str = "Hello Overloading";
             ovInt.Display(str);

            // Access the indexer property on the IndexerProperty class,
            // specifying the index value of 42, and display the result
            // in the console output.

            // SKIPPED BY MENTOR'S PERMISSION

            // Declare two int variables named x and y with the initial
            // values of 3 and 4. Then display the two values on the console.
            // Then call the GenericSwapMethod, passing in the two parameters.
            // After that, display the values on the console output and see
            // that they are swapped.

            Generics gn = new Generics();

            int x = 3;
            int y = 4;

            WriteLine();
            {
                WriteLine($"(x, y) -> ({x}, {y})");
                gn.GenericSwapMethod(x, y);
                WriteLine($"(x, y) -> ({x}, {y})");
            }


            // Declare an array of int named numbers and initialize
            // it with the element values: 1, 2, 3, 4, 5, 6, 7, 8.
            // Then call the DisplayEvens method and see that only even
            // elements are displayed.

            Linq nums = new Linq();

            int [] numbers = new int[] {1, 2, 3, 4, 5, 6, 7, 8};

            Linq.DisplayEvens(numbers);

            // Call the AddIntegersFromOneUpTo method with a parameter set to 100.
            // Then display the result on the console output.

            Gauss addInts = new Gauss();

            int num = Gauss.AddIntegersFromOneUpTo(100);
            WriteLine(num);

        }
    }
}
