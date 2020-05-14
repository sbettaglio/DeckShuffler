using System;
using System.Collections.Generic;

namespace DeckShuffler
{
  public class DeckCreator
  {
    public List<Card> CreateAndShuffleDeck()
    {
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
      return cardDeck;
    }
  }
}