using System.Diagnostics;
using CRUDelicious.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUDelicious.Controllers;

public class DishController : Controller
{
    private MyContext db;

    public DishController(MyContext context)
    {
        db = context; // if you use _context above use it here too (Make sure this matches on all controller files)
    }


    [HttpGet("")]
    public IActionResult Dashboard()
    {
        List<Dish> allDishes = db.Dishes.ToList();
        return View("Dashboard", allDishes);
    }

    [HttpGet("/dish/new")]
    public IActionResult AddDish()
    {
        return View();
    }

    [HttpPost("/dish/createDish")]
    public IActionResult CreateDish(Dish theDish)
    {
        if (ModelState.IsValid)
        {
            db.Dishes.Add(theDish);
            db.SaveChanges();
            return Redirect("/");
        }
        else
        {
            return View("AddDish");
        }
    }

    [HttpGet("dish/{dishId}/")]
    public IActionResult ViewDish(int dishId)
    {
        Dish? item = db.Dishes.FirstOrDefault(item => item.DishId == dishId);
        if (item == null)
        {
            return RedirectToAction("dashboard", "Dish");
        }
        else
        {
            return View("ViewDish", item);
        }
    }

    [HttpGet("/dish/{dishId}/edit")]
    public IActionResult EditDish(int dishId)
    {
        Dish? item = db.Dishes.FirstOrDefault(item => item.DishId == dishId);
        if (item == null)
        {
            return RedirectToAction("dashboard");
        }
        else
        {
            return View("editDish", item);
        }
    }

    [HttpPost("/dish/{dishId}/update")]
    public IActionResult UpdateDish(Dish d, int dishId)
    {
        if (ModelState.IsValid)
        {
            Dish? item = db.Dishes.FirstOrDefault(item => item.DishId == dishId);
            if (item == null)
            {
                return RedirectToAction("dashboard");
            }
            else
            {
                item.DishName = d.DishName;
                item.Chef = d.Chef;
                item.Tastiness = d.Tastiness;
                item.Calories = d.Calories;
                item.Description = d.Description;
                item.UpdatedAt = DateTime.Now;

                db.Dishes.Update(item);
                db.SaveChanges();
                return Redirect("/");
            }
        }
        else
        {
            return View("EditDish", dishId);
        }
    }

    [HttpGet("/dish/{dishId}/delete")]
    public IActionResult DeleteDish(int dishId)
    {
        Dish? item = db.Dishes.FirstOrDefault(item => item.DishId == dishId);
        if (item != null)
        {
            db.Dishes.Remove(item);
            db.SaveChanges();
        }
        return RedirectToAction("dashboard");
    }
}