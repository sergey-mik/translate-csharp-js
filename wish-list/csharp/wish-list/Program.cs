// namespace, which provides fundamental classes and base classes that define commonly-used value and reference data types
using System;

// use classes, it allows for better code organization, reusability, and maintainability
class WishList
{
    // the Main method is defined as the entry point of the program
    static void Main()
    {
        // within the Main method, a string array called iWishFor is defined and initialized with six different wish strings
        string[] iWishFor = {
            "An original eight track of William Shatner's 'Lucy in the Sky with Diamonds'",
            "The ability to think of interesting wishes on short notice",
            "A washtub of Skittles",
            "World peace, but not the kind of world peace where all the humans are removed from existence",
            "A TV that is NOT internet-capable",
            "The ability to fly, but, like, really fast...not just, like, how fast I can walk, but, like, fast, you know?"
        };

        Console.WriteLine("My wishes...");

        // loop is used to iterate through each string (wish) in the iWishFor array and print it to the console
        foreach (string wish in iWishFor)
        {
            Console.WriteLine(wish);
        }
    }
}
