using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman
{
    class Gameloop : Wortgenerator
    {
        // Eigenschaften //
        public char UserTry { get; set; }
        public int Versuche { get; set; }

        // Methoden //
        private void SetUserTry()
        // Der Nutzer gibt hier seinen geratenen Buchstaben ein
        {
            try
            {
                Console.Write("Versuch: ");
                UserTry = char.Parse(Console.ReadLine().ToLower());
            }


            catch (FormatException) 
            { 
                Console.WriteLine("Die Eingabe war zu lang...");
                SetUserTry();
            }

        }

        private void CheckInput()
        // Prüft ob der eingegebene Buchstabe sich im Wort befindet
        {

            int foundLetter = 0;

            for (int i = 0; i < HiddenWordLetters.Length; i++)
            {
                if (HiddenWordLetters[i] == UserTry)
                {
                    HiddenWord[i] = UserTry;
                    foundLetter += 1;
                } 
            }

            if (foundLetter < 1)
            {
                Versuche -= 1;
                Console.WriteLine("Leider falsch du hast noch {0} Versuche übrig", Versuche);
                Console.ReadKey();
            }
            
        }

        
        private int WinCondition()
        // Prüft die Siegesbedingung
        {
            string checkWord = null;
            foreach (char letter in HiddenWord)
            {
                checkWord += letter;
            }

            if (checkWord == Word)
            {
                Console.WriteLine("Du hast das Wort gefunden !!!");
                Console.ReadKey();
                Console.Clear();
                return 1;
            }

            else
            {
                return 0;
            }
        }
        

        public void GameStart()
        // Startet das Spiel
        {
            Versuche = 9;
            Wortgenerator newWord = new Wortgenerator();
            while (Versuche != 0 && WinCondition() != 1)
            {
                ShowHiddenWord();
                SetUserTry();
                CheckInput();
                Console.Clear();

            }

            if (Versuche == 0)
            {
                Console.WriteLine("Das gesuchte Wort war {0}", Word);
            }

            
        }
    }
}
