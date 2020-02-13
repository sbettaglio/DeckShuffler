namespace DeckShuffler
{
  public class Card
  {
    //PROPERTIES

    //value
    //public int Value { get; set; }
    //rank
    public string Rank { get; set; }
    //suit
    public string Suit { get; set; }
    //color
    public string ColorOfTheCard { get; set; }

    //METHOD
    public string DisplayCard()
    {
      return $"{Rank} of {Suit}";
    }
    public int GetCardValue()
    {
      if (Rank == "ace")
      {
        return 11;
      }
      else if (Rank == "king" || Rank == "queen" || Rank == "jack")
      {
        return 10;
      }
      else
      {
        return int.Parse(Rank);
      }
    }
  }
}