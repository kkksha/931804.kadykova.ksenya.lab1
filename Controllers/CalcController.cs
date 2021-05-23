using System;
using Microsoft.AspNetCore.Mvc;
using lab1.Models;


namespace lab1.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UsingModelCalculate()
        {

            Model l = Calculate();

            return View(l);

        }

        public IActionResult DataCalculate()
        {

            ViewData["data"] = Calculate();

            return View();


        }

        public IActionResult BagCalculate()
        {
            ViewBag.data = Calculate();

            return View();

        }

        public IActionResult ServiceInjectionCalculate()
        {

            return View();
        }

        public Model Calculate()
        {
            var rand = new Random();

            int val1 = rand.Next(0, 10);
            int val2 = rand.Next(0, 10);

            int result;
            try
            {
                result = val1 / val2;
            }
            catch (DivideByZeroException)
            {
                result = -1;
            }

            return new Model
            {
                first = val1,
                second = val2,
                resAdd = val1 + val2,
                resSub = val1 - val2,
                resDiv = result,
                resMult = val1 * val2
            };
        }
    }
}
