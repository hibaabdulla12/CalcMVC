using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mynew1.Models;
namespace mynew1.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {
            return View(new calc());
        }
        [HttpPost]
        public ActionResult Index(calc c,string calculate)
        {
            if(calculate=="add")
            {
                c.res = c.num1 + c.num2;
            }
            else if(calculate== "minus")
            {
                c.res = c.num1 - c.num2;
            }
            else if(calculate== "multi")
            {
                c.res = c.num1 * c.num2;
            }
            else
            {
                c.res = c.num1 / c.num2;
            }
            return View(c);
        }
    }
}