using Microsoft.AspNetCore.Mvc;
using Mad.Models;

namespace Mad.Controllers
{
  public class HomeController : Controller
  {

    [Route("/form")]
    public ActionResult Form()
    {
      return View();
    }
    [Route("/MadLibs")]
        public ActionResult MadLibs()
        {
          MadVariable myMadVariable = new MadVariable();
          myMadVariable.SetPerson1(Request.Query["person1"]);
          myMadVariable.SetPerson2(Request.Query["person2"]);
          myMadVariable.SetAnimal(Request.Query["animal"]);
          myMadVariable.SetExclamation(Request.Query["exclamation"]);
          myMadVariable.SetVerb(Request.Query["verb"]);
          myMadVariable.SetNoun(Request.Query["noun"]);
          myMadVariable.SetGuy(Request.Query["guy"]);
          return View(myMadVariable);
        }
    // [Route("/greeting_card")]
    // public ActionResult GreetingCard()
    // {
    //   MadVariable myMadVariable = new MadVariable();
    //   myMadVariable.SetRecipient(Request.Query["recipient"]);
    //   myMadVariable.SetSender(Request.Query["sender"]);
    //   return View("Hello", myMadVariable);
    // }
  }
}
