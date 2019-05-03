
using System.Collections.Generic;
using System;
namespace Hangman.Models
{


public class Guess
{
  private string _quessLetter;
  private static string _secretWord = "venera";
  private static List<Guess> allguesses = new List<Guess>();
  private static int _score =6;
  private string _photo;


  public Guess(string guessLetter)
  {
    _quessLetter = guessLetter;
    allguesses.Add(this);
    SetStatus();

  }

  public string GetPhoto()
  {
    return _photo;
  }
  public static Guess GetCurrentGuess()
  {
    return allguesses[0];
  }

  public int GetScore()
  {
    return _score;
  }

  public void SetScore(int newScore)
  {
    _score = newScore;
    SetStatus();
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
  private void SetStatus()
  {
    if(_score == 6)
    {
      _photo = "1.jpg";
    }
    if(_score == 5)
    {
      _photo = "2.jpg";
    }
    if(_score == 4)
    {
      _photo = "3.jpg";
    }
    if(_score == 5)
    {
      _photo = "4.jpg";
    }
  }

  public static string FindMatch()
  {
    string result= "";
    int score = 6;

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
