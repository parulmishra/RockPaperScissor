using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using RockPaperScissor.Models;
using System;

namespace RockPaperScissor.Tests
{
  [TestClass]
  public class RockPaperScissorTest
  {
    [TestMethod]
    public void Play_ShouldReturnsDrawonRock_String()
    {
      //Arrange
      string expected = "Draw";
    //Act
      RockPaperScissorClass rps = new RockPaperScissorClass("Rock");
      rps.SetComputerChoice("Rock");
      string actual = rps.Play();
      //Assert
      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void Play_ShouldReturnsDrawonPaper_String()
    {
      //Arrange
      string expected = "Draw";
    //Act
      RockPaperScissorClass rps = new RockPaperScissorClass("Paper");
      rps.SetComputerChoice("Paper");
      string actual = rps.Play();
      //Assert
      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void Play_ShouldReturnsDrawonScissor_String()
    {
      //Arrange
      string expected = "Draw";
    //Act
      RockPaperScissorClass rps = new RockPaperScissorClass("Scissor");
      rps.SetComputerChoice("Scissor");
      string actual = rps.Play();
      //Assert
      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void Play_ShouldReturnsComputerWinsonRock_String()
    {
      //Arrange
      string expected = "User Wins";
    //Act
      RockPaperScissorClass rps = new RockPaperScissorClass("Rock");
      rps.SetComputerChoice("Scissor");
      string actual = rps.Play();
      //Assert
      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void Play_ShouldReturnsComputerWinsonPaper_String()
    {
      //Arrange
      string expected = "User Wins";
    //Act
      RockPaperScissorClass rps = new RockPaperScissorClass("Paper");
      rps.SetComputerChoice("Rock");
      string actual = rps.Play();
      //Assert
      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void Play_ShouldReturnsComputerWinsonScissor_String()
    {
      //Arrange
      string expected = "User Wins";
    //Act
      RockPaperScissorClass rps = new RockPaperScissorClass("Scissor");
      rps.SetComputerChoice("Paper");
      string actual = rps.Play();
      //Assert
      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void Play_ShouldReturnsRandomResultswithRandomComputerInputsonUserRock_String()
    {
      string expected = "";
      RockPaperScissorClass rps = new RockPaperScissorClass("Rock");
      string compChoice = rps.GetComputerChoice();
      if(compChoice != null)
      {
        if(compChoice == "Rock")
        expected = "Draw";
        else if(compChoice == "Scissor")
        expected = "User Wins";
        else if(compChoice == "Paper")
        expected = "Computer Wins";
      }
      string actual = rps.Play();
      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void Play_ShouldReturnsRandomResultswithRandomComputerInputsonUserPaper_String()
    {
      string expected = "";
      RockPaperScissorClass rps = new RockPaperScissorClass("Rock");
      string compChoice = rps.GetComputerChoice();
      if(compChoice != null)
      {
        if(compChoice == "Paper")
        expected = "Computer Wins";
        else if(compChoice == "Rock")
        expected = "Draw";
        else if(compChoice == "Scissor")
        expected = "User Wins";
      }
      string actual = rps.Play();
      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void Play_ShouldReturnsRandomResultswithRandomComputerInputsonUserScissor_String()
    {
      string expected = "";
      RockPaperScissorClass rps = new RockPaperScissorClass("Scissor");
      string compChoice = rps.GetComputerChoice();
      if(compChoice != null)
      {
        if(compChoice == "Scissor")
        expected = "Draw";
        else if(compChoice == "Paper")
        expected = "User Wins";
        else if(compChoice == "rock")
        expected = "Computer Wins";
      }
      string actual = rps.Play();
      Assert.AreEqual(expected, actual);
    }

  }
}
