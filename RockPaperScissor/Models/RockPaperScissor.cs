using System;
using System.Collections.Generic;

namespace RockPaperScissor.Models
{
  public class RockPaperScissorClass
  {
    private string _computerChoice;
    private string _userChoice;
    private static string[] _inputs = {"Rock", "Paper", "Scissor"};

    public RockPaperScissorClass(string userChoice)
    {
      _userChoice = userChoice;
       Random r = new Random();
       _computerChoice = _inputs[r.Next(0, _inputs.Length)];
    }
    public void SetComputerChoice(string computerChoice)
    {
      _computerChoice = computerChoice;
    }
    public string GetComputerChoice()
    {
      return _computerChoice;
    }
    public string GetUserChoice()
    {
      return _computerChoice;
    }
    public string Play()
    {
      if(_userChoice == null || _computerChoice == null)
      return "Plaese enter valid choices";
      else if (_computerChoice != null && _userChoice != null)
      {
        if(_userChoice ==  _computerChoice)
        return "Draw";
        else if(_computerChoice == "Rock" && _userChoice == "Scissor")
        return "Computer Wins";
        else if(_computerChoice == "Paper" && _userChoice == "Rock")
        return "Computer Wins";
        else if(_computerChoice == "Scissor" && _userChoice == "Paper")
        return "Computer Wins";
        else if(_computerChoice == "Scissor" && _userChoice == "Rock")
        return "User Wins";
        else if(_computerChoice == "Rock" && _userChoice == "Paper")
        return "User Wins";
        else if(_computerChoice == "Paper" && _userChoice == "Scissor")
        return "User Wins";
      }
        return "";
    }
  }
}
