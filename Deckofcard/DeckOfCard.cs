using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    internal class DeckOfCard
    {
        
             string [] deck = new string[52];
            string[] suit = { "Clubs", "Diamonds", "Hearts", "Spades" };
            string[] rank = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
            string[,] playCards = new string[4,9];
            static Random random = new Random();
          
            public void alignCards()
            {
                int deckIndex = 0;
                for (int i = 0; i < suit.Length; i++)
                {
                    for (int j = 0; j < rank.Length; j++)
                    {
                        deck[deckIndex] = rank[j] + " of " + suit[i];
                        deckIndex++;
                    }
                }
            }     
            
            public string[] suffleCards()
            {
                int j = 0;
                string temp;
                for (int i = 0; i < deck.Length; i++)
                {
                    j = random.Next(52);
         
                    temp = deck[i];
                    deck[i] = deck[j];
                    deck[j] = temp;
                }
                return deck;
            }   
            public void displayCards(string[] deck)
            {
                int deckindex = 0;

                for (int i = 0; i < playCards.Length; i++)
                {
                    Console.WriteLine("player is " + (i + 1));
                    for (int j = 0; j < 9; j++)
                    {
                        playCards[i,j] = deck[deckindex];
                        Console.WriteLine(playCards[i,j]);
                        deckindex++;
                    }
                    Console.WriteLine("");
                }
            }
     }
}
