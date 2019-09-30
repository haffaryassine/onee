using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Monster.Models;

namespace Monster.Controllers
{
    public class AventureController : Controller
    {
        public IActionResult Index()
        {          
            ViewBag.titre = "Aventures";
            //string[] element = new string[] { "un", "deux", "trois", "quatres" };
            //ViewBag.element = element;
            List<Aventure> maListe = new List<Aventure>();
            maListe.Add(new Aventure()
            {
                Id = 1,
                Titre = "Titre 1"
            });

            maListe.Add(new Aventure()
            {
                Id = 2,
                Titre = "Titre 2"
            });

            maListe.Add(new Aventure()
            {
                Id = 3,
                Titre = "Titre 3"
            });
            return View(maListe);
        }
    }
}