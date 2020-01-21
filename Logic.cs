using DigitalDictionaryApp.Objects;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DigitalDictionaryApp
{
    public static class Logic
    {

        //most of the work is done in this method, which defines which letters eliminate words from the end search for the longest word.
        //added 3 extra "bad letters" to include the scenario of multiple words of the highest letter count.
        public static List<string> GetDigitisableWordList()
        {
            List<string> wordList = JsonConvert.DeserializeObject<List<string>>(File.ReadAllText(@"C:\Users\UFAC014\source\repos\DigitalDictionaryApp\DigitalDictionaryApp\Objects\dictionary_array.json"));
            List<string> newList = new List<string>();


            foreach (string str in wordList)
            {
                if (str.Contains('k') | str.Contains('m') | str.Contains('v') | str.Contains('w') | str.Contains('x') | str.Contains('z') | str.Contains('i') | str.Contains('o') | str.Contains('s'))
                {

                }
                else
                {
                    newList.Add(str);
                }
            }
            return newList;
        }

        //more practice with Linq is would be important, below linq query ripped from google would have saved a great deal of time if I knew it before. 
        //Also added a few extra lines to find out words with the same length to not just report on the first instance of the word with most characters and report on all instances.

        public static void WriteLongestWordToConsole()
        {
            List<string> validWordList = GetDigitisableWordList();
            var sortedWords = validWordList
                .OrderByDescending(x => x.Length);

            var longestWord = sortedWords.First().Length;

            foreach (string str in sortedWords)
            {
                if (str.Length == sortedWords.First().Length)
                {
                    Console.WriteLine(str);
                }
            }
        }

        //unneccessary method in the end, used during writing this program to make sure deserialisation had worked.
        public static void WriteToConsole(List<string> wordList)
        {
            foreach (string str in wordList)
            {
                Console.WriteLine(str);
            }
        }

        //in the end unneccessary extra method to define which letters are or are not usable for the exercise.
        public static List<char> CreateNonDigitisableLettersList()
        {
            List<char> nonDigitisableLetters = new List<char>();

            /*digitisableLetters.Add('a');
            digitisableLetters.Add('b');
            digitisableLetters.Add('c');
            digitisableLetters.Add('d');
            digitisableLetters.Add('e');
            digitisableLetters.Add('f');
            digitisableLetters.Add('g');
            digitisableLetters.Add('h');
            digitisableLetters.Add('i');
            digitisableLetters.Add('j');
            digitisableLetters.Add('l');
            digitisableLetters.Add('n');
            digitisableLetters.Add('o');
            digitisableLetters.Add('p');
            digitisableLetters.Add('q');
            digitisableLetters.Add('r');
            digitisableLetters.Add('s');
            digitisableLetters.Add('t');
            digitisableLetters.Add('u');
            digitisableLetters.Add('y');*/

            nonDigitisableLetters.Add('k');
            nonDigitisableLetters.Add('m');
            nonDigitisableLetters.Add('v');
            nonDigitisableLetters.Add('w');
            nonDigitisableLetters.Add('x');
            nonDigitisableLetters.Add('z');

            return nonDigitisableLetters;
        }
     }
}



