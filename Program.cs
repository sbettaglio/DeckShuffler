using System;
using System.Collections.Generic;

namespace DeckShuffler
{
  class Program
  {
    static void Main(string[] args)
    {
      //Once the program starts, you should create a new deck.
      var suits = new List<string>() { "clubs", "spades", "hearts", "diamonds" };
      var ranks = new List<string>() { "ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king" };
      var cardDeck = new List<Card>();
      for (var i = 0; i < suits.Count; i++)
      {
        for (var j = 0; j < ranks.Count; j++)
        {
          var card = new Card();
          card.Rank = ranks[j];
          card.Suit = suits[i];
          if (card.Suit == "diamonds" || card.Suit == "hearts")
          {
            card.ColorOfTheCard = "red";
          }
          else
          {
            card.ColorOfTheCard = "black";
          }
          cardDeck.Add(card);
        }

      }
      Random rnd = new Random();
      int n = 52;
      for (var i = n - 1; i >= 0; i--)
      {
        var j = rnd.Next(cardDeck.Count);
        //swap items[i] with items[j]
        var swap = cardDeck[i];
        cardDeck[i] = cardDeck[j];
        cardDeck[j] = swap;

      };

      var playerHand = new List<Card>();

      Console.WriteLine($"The first card is {cardDeck[0].Rank} of {cardDeck[0].Suit} ");
      Console.WriteLine($"The first card is {cardDeck[0].DisplayCard()} has a value of {cardDeck[0].GetCardValue()}");

      //remove it from the deck
      playerHand.Add(cardDeck[0]);
      cardDeck.RemoveAt(0);

      string input = "";
      while (input == "" && cardDeck.Count > 0)
      {

        Console.WriteLine($"The player has {playerHand.Count} cards");
        var total = 0;
        for (int i = 0; i < playerHand.Count; i++)
        {
          total += playerHand[i].GetCardValue();
        }
        Console.WriteLine($"The current total is {total}");

        Console.WriteLine("hit enter...... you want to see the next card?");

        input = Console.ReadLine().ToLower();
        if (input == "")
        {
          Console.WriteLine($"The next card is {cardDeck[0].DisplayCard()} has a value of {cardDeck[0].GetCardValue()}");
          playerHand.Add(cardDeck[0]);
          cardDeck.RemoveAt(0);
        }
      }
    }
  }
}

