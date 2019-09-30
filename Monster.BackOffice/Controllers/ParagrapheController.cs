using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Monster.Core.Data.Models;

namespace Monster.BackOffice.Controllers

  
{
    public class ParagrapheController : Controller
    {
        #region A supprimmer après Entities
        private List<Paragraphe> maListe = new List<Paragraphe>()
    {
        new Paragraphe(){ Id = 1 , Numero = 1, Titre ="Titre1", Description ="descriptionnnnnnnnnnnnnnnnnnnnnnnnnnnn111" },
        new Paragraphe(){ Id = 2 , Numero = 2, Titre ="Titre2",Description ="descriptionnnnnnnnnnnnnnnnnnnnnnnnnnnnn2222" },
        new Paragraphe(){ Id = 3 , Numero = 3, Titre ="Titre3" },
        new Paragraphe(){ Id = 4 , Numero = 4, Titre ="Titre4" },
        new Paragraphe(){ Id = 5 , Numero = 5, Titre ="Titre5" },
    };
        #endregion
        #region Méthode public

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Paragraphe pargraphe)
        {
            return View();
        }

        public ActionResult Edit(int id)
        {

            Paragraphe paragraphe = null;

            paragraphe = maListe.First(item => item.Id == id);
            return View(paragraphe);
        }


        #endregion
    }
}