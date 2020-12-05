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

        
        public IActionResult Sil(int id)
        {
            var dersler = context.Dersler.Find(id);
            context.Remove(dersler);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DersGetir(int id)
        {
            var ders = context.Dersler.Find(id);

            return View(ders);
        }
        [HttpPost]
        public IActionResult Guncelle(Ders d)
        {
            var ders = context.Dersler.Find(d.Id);
            ders.Isim = d.Isim;
            context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}