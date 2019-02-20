using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;
using System.Collections.Generic;

namespace Tamagotchi.Controllers
{
  public class TamagotchiController : Controller
  {

    [HttpGet("/tamagotchi")]
    public ActionResult Index()
    {

      List<Pet> allPets = Pet.GetAll();
      return View(allPets);

    }

    [HttpGet("/tamagotchi/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/tamagotchi")]
    public ActionResult Create(string name)
    {
        Pet myPet = new Pet(name, 70, 70, 70);
        return RedirectToAction("Index");

    }

    [HttpGet("/tamagotchi/{id}")]
    public ActionResult Show(int id)
    {
      Pet pet = Pet.Find(id);
      return View(pet);
    }

    [HttpPost("/tamagotchi/{id}/addfood")]
    public ActionResult Update(int id)
    {
      Pet pet = Pet.Find(id);
      pet.AddFood();
      return RedirectToAction("Show");
    }

    [HttpPost("/tamagotchi/{id}/addrest")]
    public ActionResult Update2(int id)
    {
      Pet pet = Pet.Find(id);
      pet.AddRest();
      return RedirectToAction("Show");
    }

    [HttpPost("/tamagotchi/{id}/addattention")]
    public ActionResult Update3(int id)
    {
      Pet pet = Pet.Find(id);
      pet.AddAttention();
      return RedirectToAction("Show");
    }

    [HttpPost("/tamagotchi/{id}/timepass")]
    public ActionResult Update4(int id)
    {
      Pet pet = Pet.Find(id);
      pet.TimePass();
      return RedirectToAction("Show");
    }

    [HttpPost("/tamagotchi/{id}/delete")]
    public ActionResult Update5(int id)
    {
      Pet pet = Pet.Find(id);
      pet.Delete(id);
      return RedirectToAction("Index");
    }

    }
  }
