﻿using System.Diagnostics;

namespace VirtualPet
{
    internal class Program
    {
        static Pikachu pikachu = Pikachu.LoadPikachu();
        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Menu();
                pikachu.ReduceFoodAndOther();
                Game();
                Thread.Sleep(2000);
            }
            
        }

        static void Game()
        {
            char menuChoice = Console.ReadKey().KeyChar;

            switch (menuChoice)
            {
                case '1':
                    pikachu.FeedPikachu();
                    break;
                case '2':
                    pikachu.CleanPikachu();
                    
                    break;
                case '3':
                    pikachu.PetPikachu();
                    
                    break;
                default:
                    Main();
                    break;
            }
        }

        static void Menu()
        {
            pikachu.ShowPikachu();
            Console.WriteLine();
            Console.WriteLine("1) Feed Pikachu");
            Console.WriteLine("2) Clean Pikachu");
            Console.WriteLine("3) Pet Pikachu");
            Console.WriteLine("4) Exit App");
        }

        /* Chættbått’n
           Du skal lage en app hvor man kan lage sin egen chatbot - og deretter velge å snakke med den:)
           Brukeren skal få prompt på chættbått navn, og deretter mulighet til å skrive inn forskjellige tilbakemeldinger 
           svar som chættbått’n skal trekke et tilfeldig svar fra og svare brukeren med når den startes opp.
           Bruk gjerne en meny for å gå inn i de forskjellige modusene: “mekke en chættbått” og “preke med en chættbått”
           BONUS:
           Mulighet til å lage flere chættbåtts, brukeren skal kunne se en liste av tilgjengelige chættbåtts og velge hvem h*n vil snakke med 
           - her må det brukes List fra neste ukes pensum.
        */
    }
}
