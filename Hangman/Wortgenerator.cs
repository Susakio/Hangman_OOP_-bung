using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Hangman
{
    class Wortgenerator : Wörterliste
    {
        // Eigenschaften //
        public string Word { get; set; }
        public char[] HiddenWordLetters { get; set; }

        public List<char> HiddenWord = new List<char>();

        // Konstruktor //
        public Wortgenerator()
        // Weist der Variable HiddenWord ein zufälliges Wort aus der Wörterliste zu 
        {
            string[] lines = File.ReadAllLines(FilePath);
            var rand = new Random();
            int wordIndex;

            wordIndex = rand.Next(lines.Length);

            Word = lines[wordIndex];

            HiddenWordLetters = Word.ToCharArray();

            foreach (char letter in HiddenWordLetters)
            {
                HiddenWord.Add('-');
            }

        }

        // Methoden //
        public void ShowHiddenWord()
        // Zeigt die länge des gesuchten Wortes durch "_" an
        {
            foreach(char letter in HiddenWord)
            {
                Console.Write(letter);
            }
            Console.WriteLine("");
        }

    }
}
