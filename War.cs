using System;
using System.Collections.Generic;

namespace DeckShuffler
{
  public class War
  {

    public void PlayWar(List<Card> cardDeck, List<Card> playerHand, List<Card> opponentHand)
    {
      var keepPlaying = true;
      while (keepPlaying || cardDeck.Count > 2)
      {
        Console.WriteLine($"Player one drew a {cardDeck[0].DisplayCard()}");
        Console.WriteLine($"Player two drew a {cardDeck[1].DisplayCard()}");
        CheckWinner(playerHand, opponentHand, cardDeck);
        Console.WriteLine($"{cardDeck.Count}, {playerHand.Count}, {opponentHand.Count}");
        Console.WriteLine($"Another hand? (Y)/(N)");
        Console.ReadKey();
      }
    }
    public void CheckWinner(List<Card> playerHand, List<Card> opponentHand, List<Card> cardDeck)
    {
      if (cardDeck[0].GetCardValue() > cardDeck[1].GetCardValue())
      {
        Console.WriteLine($"Player one wins!");
        playerHand.Add(cardDeck[0]);
        playerHand.Add(cardDeck[1]);
        cardDeck.RemoveRange(0, 2);
      }
      else if (cardDeck[0].GetCardValue() < cardDeck[1].GetCardValue())
      {
        Console.WriteLine($"Player two wins!");
        opponentHand.Add(cardDeck[0]);
        opponentHand.Add(cardDeck[1]);
        cardDeck.RemoveRange(0, 2);
      }
      else
      {
        Console.WriteLine("War!");
        //need to account for not enough cards in deck
        TieBreaker(playerHand, opponentHand, cardDeck);
      }
    }
    public void TieBreaker(List<Card> playerHand, List<Card> opponentHand, List<Card> cardDeck)
    {
      if (cardDeck[8].GetCardValue() > cardDeck[9].GetCardValue())
      {
        Console.WriteLine("Player one wins!");
        for (var i = 0; i < 10; i++)
        {
          playerHand.Add(cardDeck[i]);
        }
        cardDeck.RemoveRange(0, 9);
      }
      else if (cardDeck[8].GetCardValue() < cardDeck[9].GetCardValue())
      {
        Console.WriteLine("Player two wins!");
        for (var i = 0; i < 10; i++)
        {
          opponentHand.Add(cardDeck[i]);
        }
        cardDeck.RemoveRange(0, 9);
      }
    }
  }
}