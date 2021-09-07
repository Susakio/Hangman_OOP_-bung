using System;

namespace Hangman
{
    class Program 
    {
        static void Main(string[] args)
        {
            Hauptmenü MainMenu = new Hauptmenü();
            Wörterliste Liste = new Wörterliste();

            while (MainMenu.InputUser != "4")
            {
                MainMenu.ShowOptions();
                MainMenu.SetInputUser();

                switch (MainMenu.InputUser)
                {
                    case "1":
                        Gameloop Game = new Gameloop();
                        Game.GameStart();
                        MainMenu.InputUser = null;
                        break;

                    case "2":
                        Liste.AddWordToList();
                        MainMenu.InputUser = null;
                        break;

                    case "3":
                        Liste.DelWordFromList();
                        MainMenu.InputUser = null;
                        break;

                    case "4":
                        break;

                    default:
                        Console.WriteLine("\nDie Funktion existiert nicht bitte versuchen Sie es noch einmal...\n");
                        MainMenu.InputUser = null;
                        break;
                }
            }
        }
    }
}
