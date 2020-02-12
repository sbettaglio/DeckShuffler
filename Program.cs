using System;
using System.Collections.Generic;

namespace DeckShuffler
{
  class Program
  {
    static void Main(string[] args)
    {
      //Once the program starts, you should create a new deck.
      var cardDeck = new List<string>()
        {
            "Ace of Spades",
            "Two of Spades",
            "Three of Spades",
            "Four of Spades",
            "Five of Spades",
            "Six of Spades",
            "Seven of Spades",
            "Eight of Spades",
            "Nine of Spades",
            "Ten of Spades",
            "Jack of Spades",
            "Queen of Spades",
            "King of Spades",
            "Ace of Clubs",
            "Two of Clubs",
            "Three of Clubs",
            "Four of Clubs",
            "Five of Clubs",
            "Six of Clubs",
            "Seven of Clubs",
            "Eight of Clubs",
            "Nine of Clubs",
            "Ten of Clubs",
            "Jack of Clubs",
            "Queen of Clubs",
            "King of Clubs",
            "Ace of Hearts",
            "Two of Hearts",
            "Three of Hearts",
            "Four of Hearts",
            "Five of Hearts",
            "Six of Hearts",
            "Seven of Hearts",
            "Eight of Hearts",
            "Nine of Hearts",
            "Ten of Hearts",
            "Jack of Hearts",
            "Queen of Hearts",
            "King of Hearts",
            "Ace of Diamonds",
            "Two of Diamonds",
            "Three of Diamonds",
            "Four of Diamonds",
            "Five of Diamonds",
            "Six of Diamonds",
            "Seven of Diamonds",
            "Eight of Diamonds",
            "Nine of Diamonds",
            "Ten of Diamonds",
            "Jack of Diamonds",
            "Queen of Diamonds",
            "King of Diamonds",
        };

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

      var currentCardIndex = 0;

      cardDeck.Remove(cardDeck[currentCardIndex]);
      Console.WriteLine($"The top card is {cardDeck[currentCardIndex]}");
      var playerHand = new List<string>() { };
      playerHand.Add(cardDeck[currentCardIndex]);
      var playerHand2 = new List<string>() { };
      // for (var i = 0; i < playerHand.Count; i++)
      // {

      // Console.WriteLine($"This is in the playerHand List {playerHand[i]}");
      // }

      bool seeCard = true;
      while (seeCard)
      {
        Console.WriteLine("Do you want to see the NEXT card or QUIT?");
        var nextCard = Console.ReadLine().ToLower();
        if (nextCard != "next" && nextCard != "quit")
        {
          Console.WriteLine("I don't get it. Please type next or quit");
          nextCard = Console.ReadLine().ToLower();
        }
        if (nextCard == "next")
        {
          currentCardIndex++;
          Console.WriteLine($"The next card is {cardDeck[currentCardIndex]}");
          if (cardDeck.Count % 2 == 0)
          {
            cardDeck.Remove(cardDeck[currentCardIndex]);
            playerHand.Add(cardDeck[currentCardIndex]);

          }
          else
          {
            cardDeck.Remove(cardDeck[currentCardIndex]);
            playerHand2.Add(cardDeck[currentCardIndex]);

          }
          // for (var i = 0; i < playerHand.Count; i++)
          // {
          //   Console.WriteLine($"This is in the playerHand List {playerHand[i]}");
          // }
          // for (var i = 0; i < playerHand2.Count; i++)
          // {
          //   Console.WriteLine($"This is in the playerHand2 List {playerHand2[i]}");
          // }
        }
        else if (nextCard == "quit")
        {
          seeCard = false;
        }
      }
    }

  }
}
