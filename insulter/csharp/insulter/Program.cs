// import the necessary libraries
using System;
using System.Collections.Generic;

namespace Insulter
{
    // define the InsultGenerator class and the Main method
    public class InsultGenerator
    {
        public static void Main()
        {
            // this code initializes a List<string> named insults with a collection of insult strings
            List<string> insults = new List<string>
        {
            "You look like what morning breath smells like.",
            "If you tried to give me cpr I would probably throw myself back under water",
            "I am not a fan of you",
            "You think you're so special...and you are. The fact of your existence is nearly impossible to believe",
            "I'd rather walk than be on the same plane as you",
            "If I were given a million dollars to hang out with you...I would, but then I'd have to spend half of it on therapy",
            "Do you have to be so...like that?"
        };

            // initializes an empty HashSet<int> named indexes which will store the indexes of the randomly selected insults. The HashSet ensured that we did not end up with duplicate indexes
            HashSet<int> indexes = new HashSet<int>();

            // loop continues until three unique indexes are added to the indexes set. It generates a random index using the GetRandomInt method and adds it to the set
            while (indexes.Count < 3)
            {
                int candidate = GetRandomInt(0, insults.Count - 1);
                indexes.Add(candidate);
            }

            // loop iterates through the indexes set and prints the corresponding insult from the insults list using the Console.WriteLine method
            foreach (int index in indexes)
            {
                Console.WriteLine(insults[index]);
            }
        }

        // this method creates a new Random object and generates a random integer between min and max
        private static int GetRandomInt(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max + 1);
        }
    }
}
