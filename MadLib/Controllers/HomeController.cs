using Microsoft.AspNetCore.Mvc;
using MadLib.Models;

namespace MadLib.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form() { return View(); }

    [Route("/madlib")]
    public ActionResult MadLibResult(string noun, string nounOne, string verb, string pastTenseVerb, string adjective, string adjectiveOne, string typeOfBird, string roomInAHouse)
    {
      WordsLib myWordsLib = new WordsLib();
      myWordsLib.SetNoun(noun);
      myWordsLib.SetNounOne(nounOne);
      myWordsLib.SetVerb(verb);
      myWordsLib.SetPastTenseVerb(pastTenseVerb);
      myWordsLib.SetAdjective(adjective);
      myWordsLib.SetAdjectiveOne(adjectiveOne);
      myWordsLib.SetTypeofBird(typeOfBird);
      myWordsLib.SetRoomInAHouse(roomInAHouse);
      return View(myWordsLib);
    }

  }
}
