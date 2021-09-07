using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Hangman
{
    class Wörterliste : Hauptmenü
    {
        // Eigenschaften //
        public string FilePath { get; set; }

        // Konstruktor //
        public Wörterliste()
        // Erstellt falls noch nicht vorhanden eine neue Wörterliste
        {
            FilePath = Path.GetFullPath("Wörterliste.txt");

            if (!File.Exists(FilePath))
            {
                File.Create(FilePath);
            }
        }

        // Methoden //
        public void AddWordToList()
        // Fügt ein Wort der Wörterliste hinzu
        {
            string newWord;

            Console.Write("Welches Wort wollen Sie der Liste hinzufügen?: ");
            newWord = Console.ReadLine();

            File.AppendAllText(FilePath,newWord);

        }

        public void DelWordFromList()
        // Löscht ein Wort aus der Wörterliste
        {
            string[] lines = File.ReadAllLines(FilePath);
            List<string> allWords = new List<string>();
            string input;
           
            foreach (string word in lines)
            {
                allWords.Add(word);
            }

            Console.Write("Welches Wort soll entfernt werden?: ");
            input = Console.ReadLine();

            allWords.Remove(input);

            File.WriteAllText(FilePath,"");
      
            foreach (string word in allWords)
            {
               File.AppendAllText(FilePath, word.ToLower() + "\n");
            }    

        }
    }
}
