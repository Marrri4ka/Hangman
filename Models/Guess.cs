
using System.Collections.Generic;
using System;
namespace Hangman.Models
{


public class Guess
{
  private string _quessLetter;
  private static string _secretWord = "venera";
  private static List<Guess> allguesses = new List<Guess>();


  public Guess(string guessLetter)
  {
    _quessLetter = guessLetter;
    allguesses.Add(this);

  }


  public string GetLetter()
  {
    return _quessLetter;
  }

  public void SetLetter(string newLetter)
  {
    _quessLetter = newLetter;
  }

  public static List<Guess> GetAll()
  {
    return allguesses;
  }

  public static string FindMatch()
  {
    string result= "";

for (int i=0; i < _secretWord.Length; i++)
{
  bool found = false;
  for (int j=0; j < allguesses.Count; j++)
  {
    if(allguesses[j].GetLetter() == _secretWord[i].ToString())
    {
      found = true;
    }

  }
  if (found)
  {
    result += _secretWord[i];
  }
  else
  {
    result += "_";
  }


}

    return result;
  }


}
}
