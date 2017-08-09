using Microsoft.AspNetCore.Mvc;
using RockPaperScissor.Models;
using System.Collections.Generic;
using System;

namespace RockPaperScissor.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
    [HttpPost("/play")]
    public ActionResult Play()
    {
      string userChoice = Request.Form["choice"];
      RockPaperScissorClass rps = new RockPaperScissorClass(userChoice);
      return View("Index",rps);
    }

  }
}
