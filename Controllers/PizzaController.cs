using la_mia_pizzeria_static.Data;
using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            PizzeriaDbContext db = new PizzeriaDbContext();

            List<Pizza> listPizzas = db.Pizzas.ToList();

            return View(listPizzas);
        }

        public IActionResult Details(int id)
        {

            PizzeriaDbContext db = new PizzeriaDbContext();

            Pizza pizza = db.Pizzas.Where(p => p.Id == id).FirstOrDefault();

            return View(pizza);
        }
    }
}
