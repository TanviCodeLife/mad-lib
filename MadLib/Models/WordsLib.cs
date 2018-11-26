namespace MadLib.Models
{
  public class WordsLib
  {
    private string _noun;
    private string _nounOne;
    private string _verb;
    private string _adjective;
    private string _adjectiveOne;
    private string _typeOfBird;
    private string _roomInAHouse;
    private string _pastTenseVerb;

    public string GetNoun()
    {
      return _noun;
    }

    public void SetNoun(string newNoun)
    {
      _noun = newNoun;
    }

    public string GetNounOne()
    {
      return _nounOne;
    }

    public void SetNounOne(string newNounOne)
    {
      _nounOne = newNounOne;
    }
    public string GetVerb()
    {
      return _verb;
    }

    public void SetVerb(string newVerb)
    {
      _verb = newVerb;
    }

    public string GetPastTenseVerb()
    {
      return _pastTenseVerb;
    }

    public void SetPastTenseVerb(string newPastTenseVerb)
    {
      _pastTenseVerb = newPastTenseVerb;
    }

    public string GetAdjective()
    {
      return _adjective;
    }

    public void SetAdjective(string newAdjective)
    {
      _adjective = newAdjective;
    }

    public string GetAdjectiveOne()
    {
      return _adjectiveOne;
    }

    public void SetAdjectiveOne(string newAdjectiveOne)
    {
      _adjectiveOne = newAdjectiveOne;
    }

    public string GetTypeofBird()
    {
      return _typeOfBird;
    }

    public void SetTypeofBird(string newTypeOfBird)
    {
      _typeOfBird = newTypeOfBird;
    }

    public string GetRoomInAHouse()
    {
      return _roomInAHouse;
    }

    public void SetRoomInAHouse(string newRoomInAHouse)
    {
      _roomInAHouse = newRoomInAHouse;
    }

  }
}
