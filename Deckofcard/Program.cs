using System;

namespace DeckOfCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DeckOfCard player = new DeckOfCard();
            player.alignCards();
            String[] deck = player.suffleCards();
            player.displayCards(deck);

        }
    }
}
