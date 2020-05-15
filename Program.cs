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
        Console.WriteLine($"Thanks for playing!");
      }
      else
      {
        Console.WriteLine("Goodbye");
      }
    }
  }
}


