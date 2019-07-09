using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /*
    Create a dictionary with key value pairs to
    represent words (key) and its definition (value)
*/
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>() {
    {"Approach", "move towards"},
    {"Establish", "set up or found"},
    {"Engage", "consume all of one's attention or time"},
    {"Obtain", "come into possession of"},
    {"Scarce", "deficient in quantity or number compared with the demand"}
};

            // Add several more words and their definitions
            wordsAndDefinitions.Add("Policy", "a plan of action adopted by an individual or social group");
            wordsAndDefinitions.Add("Stock", "capital raised by a corporation through the issues of shares");
            wordsAndDefinitions.Add("Apparent", "clearly revealed to the mind or the senses or judgment");

            /*
                Use square brackets to get the definition of two of the
                words and then output them to the console
            */
            Console.WriteLine(wordsAndDefinitions["Policy"]);
            Console.WriteLine(wordsAndDefinitions["Stock"]);

            /*
    Below, loop over the wordsAndDefinitions dictionary to get the following output:
        The definition of (WORD) is (DEFINITION)
        The definition of (WORD) is (DEFINITION)
        The definition of (WORD) is (DEFINITION)
*/
            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
                Console.WriteLine($"The definition of {word.Key} is {word.Value}");
            }

            // Make a new list
            /*     Example of one dictionary in the list:
    {
        "word": "excited",
        "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
        "part of speech": "adjective",
        "example sentence": "I am excited to learn C#!"
    } */
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

            // Create dictionary to represent a few words
            Dictionary<string, string> excitedWord = new Dictionary<string, string>();

            // Add each of the 4 bits of data about the word to the Dictionary
            excitedWord.Add("word", "aflutter");
            excitedWord.Add("definition", "nervously excited");
            excitedWord.Add("part of speech", "adjective");
            excitedWord.Add("example sentence", "Her heart was aflutter at the thought of his return.");

            // foreach (KeyValuePair<string, string> word in excitedWord)
            // {
            //     Console.WriteLine($"{word.Key} {word.Value}");
            // }

            // Add Dictionary to your `dictionaryOfWords` list
            dictionaryOfWords.Add(excitedWord);

            // create another Dictionary and add that to the list
            Dictionary<string, string> danceWord = new Dictionary<string, string>();

            danceWord.Add("word", "moonwalk");
            danceWord.Add("definition", "a dance with a gliding motion, in which the dancer appears to be moving forward but in fact is moving backwards.");
            danceWord.Add("part of speech", "verb");
            danceWord.Add("example sentence", "Michael Jackson does the moonwalk in his current stageshow");

            /*
    Iterate your list of dictionaries and output the data, You can use the two foreach() loops below to help you start your iteration.

    Example output for one word in the list of dictionaries:
        word: excited
        definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
        part of speech: adjective
        example sentence: I am excited to learn C#!
*/

            // Iterate the List of Dictionaries
            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
                // Iterate the KeyValuePairs of the Dictionary
                // foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
                // {
                Console.WriteLine($"{word.Key}: {word.Value}");
                // }
            }

        }
    }
}



