using System;
using System.Collections.Generic;

namespace DeckShuffler
{
  class Program
  {
    static void Main(string[] args)
    {
      var create = new DeckCreator();
      var cardDeck = create.CreateAndShuffleDeck();
      var playerHand = new List<Card>();
      var opponentHand = new List<Card>();
      var war = new War();

      Console.WriteLine($"Do you want to play war?(Y)/(N)");
      var gameOn = Console.ReadLine().ToLower();

      if (gameOn == "y")
      {
        war.PlayWar(cardDeck, playerHand, opponentHand);
      }
      else
      {
        Console.WriteLine("Goodbye");
      }


      // string input = "";
      // while (input == "" && cardDeck.Count > 0)
      // {

      //   Console.WriteLine($"The player has {playerHand.Count} cards");
      //   var total = 0;
      //   for (int i = 0; i < playerHand.Count; i++)
      //   {
      //     total += playerHand[i].GetCardValue();
      //   }
      //   Console.WriteLine($"The current total is {total}");

      //   Console.WriteLine("hit enter...... you want to see the next card?");

      //   input = Console.ReadLine().ToLower();
      //   if (input == "")
      //   {
      //     Console.WriteLine($"The next card is {cardDeck[0].DisplayCard()} has a value of {cardDeck[0].GetCardValue()}");
      //     playerHand.Add(cardDeck[0]);
      //     cardDeck.RemoveAt(0);
      //   }
    }
  }
}


