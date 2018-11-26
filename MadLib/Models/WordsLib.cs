namespace MadLib.Models
{
  public class WordsLib
  {
    private string _noun;
    private string _verb;
    private string _adjective;
    private string _partOfBody

    public string GetNoun()
    {
      return _noun;
    }

    public string SetNoun(string newNoun)
    {
      _noun = newNoun;
    }

    public string GetVerb()
    {
      return _verb;
    }

    public string SetVerb(string newVerb)
    {
      _verb = newVerb;
    }

  }
}
