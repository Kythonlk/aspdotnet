using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using webmvc.Models;

namespace webmvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

        public IActionResult New()
    {
        return View();
    }

    public IActionResult RandomQuote()
    {
        var quotes = new List<Quote> 
        {
            new Quote { Text = "The greatest glory in living lies not in never falling, but in rising every .", Author = "Nelson Mandela" },
            new Quote { Text = "The way to get started is to quit talking and begin doing.", Author = "Walt Disney" },
            new Quote { Text = "The way to get startrgferghe gergertgergefge", Author = "Kavindu" },
        };


        return PartialView("_RandomQuote", quotes);
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
