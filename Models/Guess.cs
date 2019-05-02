
using System.Collections.Generic;
using System;
namespace Hangman.Models
{


public class Guess
{
  private string _quessLetter;

  public Guess(string guessLetter)
  {
    _quessLetter = guessLetter;
  }


  public string GetLetter()
  {
    return _quessLetter;
  }


  public void SetLetter(string newLetter)
  {
    _quessLetter = newLetter;
  }
}
}
