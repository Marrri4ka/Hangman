
using Microsoft.AspNetCore.Mvc;
using Hangman.Models;
using System.Collections.Generic;

namespace Hangman.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult IndexHome()
    {

      string currentGuess = Guess.FindMatch();
      return View("IndexHome", currentGuess);
    }


    [HttpPost("/letter")]
    public ActionResult AddLetter(string letter)
    {
        Guess guess = new Guess (letter);
        string currentGuess = Guess.FindMatch();
        return View("IndexHome", currentGuess);
    }

  }
}
