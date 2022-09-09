using Microsoft.AspNetCore.Mvc;
using MVCDemo.Services;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class PizzaController : Controller
    {

        public IActionResult Index()
        {
            List<Pizza> pizzas = PizzaService.GetAll();
            return View(pizzas);
        }

        public IActionResult Detail(int id)
        {
            Pizza p=PizzaService.Get(id);
            return View(p);
        }

        public IActionResult List()
        {
            List<Pizza> pizzas = PizzaService.GetAll();
            return View(pizzas);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Pizza p)
        {
            PizzaService.Add(p);
            return RedirectToAction("List");
        }

        public IActionResult Delete(int id)
        {
            Pizza p = PizzaService.Get(id);
            if (p != null)
                return View(p);
            else
                return RedirectToAction("List");
        }

        [HttpPost]
        public IActionResult Delete(Pizza p)
        {
            PizzaService.Delete(p.Id);
             return RedirectToAction("List");
        }

        //public IActionResult Edit(int id)
        //{
        //    var p = PizzaService.Where(p => p.Id == id).FirstOrDefault();

        //    return View();
        //}
        [HttpPost]
        public IActionResult Edit(Pizza pizza)
        {
            
            var name=pizza.Name;
            var price = pizza.Price;
            PizzaService.Update(pizza);
            return RedirectToAction("List");

        }
    }
}
