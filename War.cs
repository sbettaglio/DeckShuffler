using System;
using System.Collections.Generic;

namespace DeckShuffler
{
  public class War
  {

    public void PlayWar(List<Card> cardDeck, List<Card> playerHand, List<Card> opponentHand)
    {
      var keepPlaying = true;
      while (keepPlaying && cardDeck.Count > 2)
      {
        Console.WriteLine($"Player one drew a {cardDeck[0].DisplayCard()}");
        Console.WriteLine($"Player two drew a {cardDeck[1].DisplayCard()}");
        keepPlaying = CheckWinner(playerHand, opponentHand, cardDeck, keepPlaying);
        if (keepPlaying == false)
        {
          //   AnnounceWinner(playerHand, opponentHand);
          break;
        }
        Console.WriteLine($"{cardDeck.Count}, {playerHand.Count}, {opponentHand.Count}");
        Console.WriteLine($"Another hand? (Y)/(N)");
        var playOn = Console.ReadLine().ToLower();
        switch (playOn)
        {
          case "y":
            keepPlaying = true;
            break;
          default:
            keepPlaying = false;
            break;
        }
      }
      AnnounceWinner(playerHand, opponentHand);
    }
    public void AnnounceWinner(List<Card> playerHand, List<Card> opponentHand)
    {
      if (playerHand.Count > opponentHand.Count)
      {
        Console.WriteLine($"Player One is holding {playerHand.Count} cards and Player Two is holding {opponentHand.Count} cards");
        Console.WriteLine($"Player One wins!");
      }
      else if (playerHand.Count < opponentHand.Count)
      {
        Console.WriteLine($"Player One is holding {playerHand.Count} cards and Player Two is holding {opponentHand.Count} cards");
        Console.WriteLine($"Player Two wins!");
      }
    }
    public bool CheckWinner(List<Card> playerHand, List<Card> opponentHand, List<Card> cardDeck, bool keepPlaying)
    {
      if (cardDeck[0].GetCardValue() > cardDeck[1].GetCardValue())
      {
        Console.WriteLine($"Player one wins!");
        playerHand.Add(cardDeck[0]);
        playerHand.Add(cardDeck[1]);
        cardDeck.RemoveRange(0, 2);
        return keepPlaying;
      }
      else if (cardDeck[0].GetCardValue() < cardDeck[1].GetCardValue())
      {
        Console.WriteLine($"Player two wins!");
        opponentHand.Add(cardDeck[0]);
        opponentHand.Add(cardDeck[1]);
        cardDeck.RemoveRange(0, 2);
        return keepPlaying;
      }
      else
      {
        keepPlaying = CheckCardCount(playerHand, opponentHand, cardDeck);
        if (keepPlaying == false)
        {
          Console.WriteLine("Deck is out of cards");
          return keepPlaying = false;
        }
        else
        {
          Console.WriteLine($"War!");
          TieBreaker(playerHand, opponentHand, cardDeck);
          return keepPlaying;
        }
      }
    }
    public void TieBreaker(List<Card> playerHand, List<Card> opponentHand, List<Card> cardDeck)
    {
      Console.WriteLine($"Three cards burned for each player, winner of next draw takes all.");
      Console.WriteLine($"Player one drew a {cardDeck[8].DisplayCard()}");
      Console.WriteLine($"Player two drew a {cardDeck[9].DisplayCard()}");
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
    public bool CheckCardCount(List<Card> playerHand, List<Card> opponentHand, List<Card> cardDeck)
    {
      if (cardDeck.Count >= 10)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

  }
}