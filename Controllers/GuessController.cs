using Microsoft.AspNetCore.Mvc;
using Hangman.Models;
using System.Collections.Generic;

namespace Hangman.Controllers
{
  public class QuessController : Controller
  {

    [HttpGet("/makequess")]
    public ActionResult Index(int categoryId)
    {
       
       return RedirectToAction("IndexHome");
    }

  }
}
