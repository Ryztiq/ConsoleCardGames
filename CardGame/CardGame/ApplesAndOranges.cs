﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using static CardGame.Utility;
using static System.Console;

namespace CardGame
{
    internal class ApplesAndOranges:Game
    {

       
        public override void GameStart()
        {

            Clear();
            base.GameStart();
            //custom content
            deck.ConstructDeck(13, new string[]{"Apples", "Oranges"} );
            //deck.OutputCards();
            deck.Shuffle();

            while (deck.cards.Count >= 2)
            {
                GamePlay();
            }
            //if (deck.cards.Count == 2)
            //{
            //    GameEnd();
            //}

           //Game over 


        }

        private void GamePlay()
        {
            string input;

            Card a = deck.Draw();
            Print($"The first card drawn is... {a.Value} of {a.Suit}");
            Print("Is the next card the same or different suit? Y/N?");
            input = ReadLine();
            Card b = deck.Draw();
            Print($"The second card drawn is... {b.Value} of {b.Suit}");
            if (a.Suit == b.Suit && input.ToUpper() == "Y")
            {
                //player gets point
                player.score++;
                Print("You are correct!");
            }
            else if (a.Suit != b.Suit && input.ToUpper() == "N")
            {
                //player gets point
                player.score++;
                Print("You are correct!");
            }
            else
            {
                Print("Sorry that is incorrect...");
            }
            Print($"Your score is {player.score}!");
            Pause();
            Clear();
            StartNewGame();
        }

        //public void GameEnd()
        //{
        //    Print($"The game is complete! Your score is {player.score}!");
        //    Pause();
        //    //menu.GameStart();

        //}
        public void StartNewGame()
        {
            ReadKey(true);
            Clear();
            Menu menu2 = new Menu();
            menu2.Start();
        }

    }
}
