using Microsoft.AspNetCore.Mvc;
using MadLib.Models;

namespace MadLib.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form() { return View(); }

    [Route("/madlib")]
    public ActionResult MadLibResult(string noun, string verb, string adjective)
    {
      WordsLib myWordsLib = new WordsLib();
      myWordsLib.SetNoun(noun);
      myWordsLib.SetVerb(verb);
      myWordsLib.SetAdjective(adjective);
      return View(myWordsLib);
    }

  }
}
