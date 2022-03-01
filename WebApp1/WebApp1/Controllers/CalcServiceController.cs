using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp1.Models;
using WebApp1.Services;

namespace WebApp1.Controllers
{
    public class CalcServiceController : Controller
    {
        private readonly CalcService _service;

        public CalcServiceController(CalcService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PassUsingModel()
        {
            return View(_service.GetCalcModel());
        }

        public IActionResult PassUsingViewData()
        {
            var model = _service.GetCalcModel();
            ViewData["X"] = model.X;
            ViewData["Y"] = model.Y;
            ViewData["Add"] = model.Add;
            ViewData["Sub"] = model.Sub;
            ViewData["Mult"] = model.Mult;
            ViewData["Div"] = model.Div;
            return View();
        }

        public IActionResult PassUsingViewBag()
        {
            var model = _service.GetCalcModel();
            ViewBag.X = model.X;
            ViewBag.Y = model.Y;
            ViewBag.Add = model.Add;
            ViewBag.Sub = model.Sub;
            ViewBag.Mult = model.Mult;
            ViewBag.Div = model.Div;
            return View();
        }

        public IActionResult AccessServiceDirectly()
        {
            return View();
        }
    }
}
