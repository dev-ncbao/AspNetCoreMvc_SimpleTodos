using Microsoft.AspNetCore.Mvc;
using TodoMVC.Contracts;
using TodoMVC.Interfaces;

namespace TodoMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITodoServices _todoServices;

        public HomeController(ITodoServices _todoServices)
        {
            this._todoServices = _todoServices;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var data = await _todoServices.GetList();
            return View(data);
        }

        [HttpGet]
        public async Task<IActionResult> CreateTodo()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateTodo(TodoCreateModel request)
        {
            if (!ModelState.IsValid)
                return View();

            var result = await _todoServices.Create(request);
            if (result > 0)
                return RedirectToAction("Index");
            return View();
        }
    }
}