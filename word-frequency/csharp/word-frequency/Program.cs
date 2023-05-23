using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ConsoleApp
{
    public static class Program
    {
        public static void Main()
        {
            // The first line of the Main method calls the GetText method, which returns a string containing the text to be analyzed. This text is assigned to the text variable.
            var text = GetText();

            // The next line uses a regular expression to remove all characters from the text variable that are not letters or spaces. The resulting string is assigned back to the text variable.
            text = Regex.Replace(text, "[^a-zA-Z ]", "");

            // The next line splits the text variable into an array of words by splitting it on spaces. This array is assigned to the words variable.
            var words = text.Split(' ');

            // Creates a new instance of the Dictionary <string, int> class and assigns it to the freqCounts variable. This dictionary will be used to store the frequency counts of each word in the text.
            var freqCounts = new Dictionary<string, int>();

            // The foreach loop that iterates over each word in the words array.
            foreach (var word in words)
            {
                // It checks if the current word is empty or contains only whitespace characters. If it does, the continue statement is executed, which skips the rest of the current iteration of the loop and moves on to the next word.
                if (string.IsNullOrWhiteSpace(word))
                {
                    continue;
                }

                // It checks if the freqCounts dictionary already contains an entry for the current word. If it does, the value associated with that key (which represents the frequency count of that word) is incremented by 1. If it doesn’t, a new entry is added to the dictionary with a key of the current word and a value of 1.
                if (freqCounts.ContainsKey(word))
                {
                    freqCounts[word]++;
                }
                else
                {
                    freqCounts[word] = 1;
                }
            }

            // The foreach loop that iterates over each key-value pair in the freqCounts dictionary. For each pair, it prints a line to the console containing the key (the word) and its associated value (the frequency count).
            foreach (var kvp in freqCounts)
            {
                // Printing a dictionary in C# requires iterating over its key-value pairs and printing each one individually, whereas in some other languages (such as JavaScript), you can simply print a dictionary (or object) directly.
                Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value);
            }
        }

        private static string GetText()
        {
            return @"
 Look again at that dot. That's here. That's home. That's us. On it everyone you love, everyone you know, everyone you ever heard of, every human being who ever was, lived out their lives. The aggregate of our joy and suffering, thousands of confident religions, ideologies, and economic doctrines, every hunter and forager, every hero and coward, every creator and destroyer of civilization, every king and peasant, every young couple in love, every mother and father, hopeful child, inventor and explorer, every teacher of morals, every corrupt politician, every ""superstar,"" every ""supreme leader,"" every saint and sinner in the history of our species lived there--on a mote of dust suspended in a sunbeam.

 The Earth is a very small stage in a vast cosmic arena. Think of the rivers of blood spilled by all those generals and emperors so that, in glory and triumph, they could become the momentary masters of a fraction of a dot. Think of the endless cruelties visited by the inhabitants of one corner of this pixel on the scarcely distinguishable inhabitants of some other corner, how frequent their misunderstandings, how eager they are to kill one another, how fervent their hatreds.

 Our posturings, our imagined self-importance, the delusion that we have some privileged position in the Universe, are challenged by this point of pale light. Our planet is a lonely speck in the great enveloping cosmic dark. In our obscurity, in all this vastness, there is no hint that help will come from elsewhere to save us from ourselves.

 The Earth is the only world known so far to harbor life. There is nowhere else, at least in the near future, to which our species could migrate. Visit, yes. Settle, not yet. Like it or not, for the moment the Earth is where we make our stand.

 It has been said that astronomy is a humbling and character-building experience. There is perhaps no better demonstration of the folly of human conceits than this distant image of our tiny world. To me, it underscores our responsibility to deal more kindly with one another, and to preserve and cherish the pale blue dot, the only home we've ever known.
 - Carl Sagan";
        }
    }
}
