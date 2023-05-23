/*
The code implements the FizzBuzz problem, which is a common programming task. The task is to print the numbers from 1 to 100, but for multiples of 3, print "fizz" instead of the number, and for multiples of 5, print "buzz" instead of the number. For numbers that are multiples of both 3 and 5, print "fizzbuzz"
*/

using System;

class Program
{
    // the Main method, which is the entry point of the program
    static void Main()
    {
        // this line starts a for loop that iterates over numbers from 1 to 100
        for (int n = 1; n <= 100; n++)
        {
            // this line checks if the current number n is divisible by both 3 and 5 (divisible by 15). If true, it proceeds to the next line
            if (n % 15 == 0)
            {
                // this line prints "fizzbuzz" to the console if the previous condition is met (n is divisible by 15)
                Console.WriteLine("fizzbuzz"); 
            }
            // if the previous condition is not met, this line checks if the current number n is divisible by 3. If true, it proceeds to the next line
            else if (n % 3 == 0)
            {
                // this line prints "fizz" to the console if the previous condition is met (n is divisible by 3)
                Console.WriteLine("fizz");
            }
            //  if none of the previous conditions are met, this line checks if the current number n is divisible by 5. If true, it proceeds to the next line.
            else if (n % 5 == 0)
            {
                // this line prints "buzz" to the console if the previous condition is met (n is divisible by 5)
                Console.WriteLine("buzz");
            }
            // if none of the previous conditions are met, it proceeds to the next line
            else
            {
                // this line prints the current number n to the console if none of the previous conditions are met
                Console.WriteLine(n);
            }
        }
    }
}
