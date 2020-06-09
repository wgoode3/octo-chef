using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OctoChef.Models;

namespace OctoChef.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            Recipe maqueChoux = new Recipe()
            {
                Title="Maque Choux",
                Ingredients=new List<string>{
                    "Corn",
                    "Onions",
                    "Bell Peppers",
                    "Celery",
                    "Diced Tomatoes",
                    "Milk"
                },
                Instructions="Chop the veggetables.\nCook the vegetables.\nStew it in the milk.\nSalt and pepper to taste!"
            };
            Recipe lentils = new Recipe()
            {
                Title="Lentils",
                Ingredients=new List<string>{
                    "Lentils",
                    "Chicken Stock",
                    "Bay Leaf",
                    "Thyme",
                    "Shallots",
                    "Red Wine Vinegar",
                    "Olive Oil",
                    "Mustard"
                },
                Instructions="Simmer the lentils in stock.\nCombine chopped shallots, vinegar, oil, mustard into dressing.\nDrain lentils and dress with dressing."
            };
            List<Recipe> cookBook = new List<Recipe>() {
                maqueChoux,
                lentils
            };
            return View(cookBook);
        }

        [HttpGet("title")]
        public IActionResult Title()
        {
            string title = "BLT";
            return View("Title", title);
        }

        [HttpGet("ingredients")]
        public IActionResult Ingredients()
        {
            List<string> ingredients = new List<string>(){
                "Bacon",
                "Lettuce",
                "Tomato",
                "Mayo",
                "Bread",
                "Mushrooms"
            };
            return View(ingredients);
        }

    }
}
