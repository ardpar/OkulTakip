using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OgrenciTakipSistemi.Models;

namespace OgrenciTakipSistemi.Controllers
{
    public class DerslerController : Controller
    {
        OkulContext context = new OkulContext();
        public IActionResult Index()
        {
            var dersler = context.Dersler.ToList();
            return View(dersler);
        }
        [HttpGet]
        public IActionResult YeniDers()
        {
            return View();
        }

        [HttpPost]
        public IActionResult YeniDers(Ders ders)
        {
            context.Dersler.Add(ders);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}