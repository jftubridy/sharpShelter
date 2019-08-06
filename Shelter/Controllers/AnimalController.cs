using Microsoft.AspNetCore.Mvc;
using Shelter.Models;
using System.Collections.Generic;
using System.Linq;


namespace Shelter.Controllers
{
    public class AnimalController : Controller
    {
        private readonly ShelterContext _db;

        public AnimalController(ShelterContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            List<Animal> AnimalModel = _db.Animal.ToList();
            return View(AnimalModel);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Animal animal)
        {
            _db.Animal.Add(animal);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            Animal thisAnimal = _db.Animal.FirstOrDefault(animal => animal.AnimalId == id);
            return View(thisAnimal);
        }
    }
}

