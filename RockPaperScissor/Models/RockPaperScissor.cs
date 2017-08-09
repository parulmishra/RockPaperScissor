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
    // public void SetComputerChoice(string computerChoice)
    // {
    //   _computerChoice = computerChoice;
    // }
    public string GetComputerChoice()
    {
      return _computerChoice;
    }
    public string GetUserChoice()
    {
      return _userChoice;
    }
    public string Play()
    {
      string result= " " ;
      if (_computerChoice != null && _userChoice != null)
      {
        if(_userChoice ==  _computerChoice)
        result="Draw";
        else if(_computerChoice == "Rock" && _userChoice == "Scissor")
        result="Computer Wins";
        else if(_computerChoice == "Paper" && _userChoice == "Rock")
        result= "Computer Wins";
        else if(_computerChoice == "Scissor" && _userChoice == "Paper")
        result="Computer Wins";
        else if(_computerChoice == "Scissor" && _userChoice == "Rock")
        result="User Wins";
        else if(_computerChoice == "Rock" && _userChoice == "Paper")
        result="User Wins";
        else if(_computerChoice == "Paper" && _userChoice == "Scissor")
        result= "User Wins";
      }
        return result;
    }
  }
}
