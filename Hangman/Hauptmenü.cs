using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman
{
    class Hauptmenü
    {
        // Eigenschaften //
        public string InputUser { get; set; }

        // Methoden //
        public void ShowOptions()
        // Zeigt dem Nutzer alle möglichen Eingaben
        {
            Console.WriteLine("[1] Spiel starten");
            Console.WriteLine("[2] Wort der Wörterliste hinzufügen");
            Console.WriteLine("[3] Wort aus der Wörterliste entfernen");
            Console.WriteLine("[4] Spiel verlassen\n");
        }
        public void SetInputUser()
        // Weist der Eigenschaft InputUser einen Wert zu
        {
            Console.Write("Eingabe: ");
            InputUser = Console.ReadLine();
            Console.WriteLine();

        }

    }
}
