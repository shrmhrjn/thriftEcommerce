using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace thriftEcommerce.Controllers
{
    public class CategoryController : Controller
    {
        // GET: CategoryController
        public IActionResult Index()
        {
            return View();
        }

        // GET: CategoryController/Details/5
        public IActionResult Show(int id)
        {
            return View();
        }

        // GET: CategoryController/Create
        public IActionResult Add()
        {
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(IFormCollection collection)
        {
            if(ModelState.IsValid){
                try
                {
                     return RedirectToAction(nameof(Index));
                }
                catch
                {
                      return View();
                }
            }
            else{
                return Content("Model Validation falied");
            }
        }

        // GET: CategoryController/Edit/5
        public IActionResult Edit(int id)
        {
            return View();
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController/Delete/5
        public IActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
