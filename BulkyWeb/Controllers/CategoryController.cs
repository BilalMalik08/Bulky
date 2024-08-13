using Bulky.Models;
using Bulky.DataAccess.Data;
using Microsoft.AspNetCore.Mvc;
using Bulky.DataAccess.Repository.IRepository;

namespace BulkyWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepo;
        public CategoryController(ICategoryRepository db)
        {
            _categoryRepo = db;
        }

        public IActionResult Index()
        {
            List<Category> objCategoryList = _categoryRepo.GetAll().ToList();
            return View(objCategoryList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "The Display Order cannot exactly match the Name.");
            }

            if (ModelState.IsValid)
            {
                _categoryRepo.Add(obj);
                _categoryRepo.Save();
                TempData["success"] = "Category Created Successfully";
                return RedirectToAction("Index", "Category");
            }

            TempData["error"] = "Category Creation Failed.";
            return View(obj);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Category? categoryFromDb1 = _categoryRepo.Get(u => u.Id == id);
            if (categoryFromDb1 == null)
            {
                TempData["error"] = "Category Not Found.";
                return NotFound();
            }

            return View(categoryFromDb1);
        }

        [HttpPost]
        public IActionResult Edit(Category obj)
        {
            if (ModelState.IsValid)
            {
                _categoryRepo.Update(obj);
                _categoryRepo.Save();
                TempData["success"] = "Category Updated Successfully";
                return RedirectToAction("Index", "Category");
            }

            TempData["error"] = "Category Update Failed.";
            return View(obj);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Category? categoryFromDb1 = _categoryRepo.Get(u => u.Id == id);
            if (categoryFromDb1 == null)
            {
                TempData["error"] = "Category Not Found.";
                return NotFound();
            }

            return View(categoryFromDb1);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            Category? obj = _categoryRepo.Get(u => u.Id == id);
            if (obj == null)
            {
                TempData["error"] = "Category Not Found.";
                return NotFound();
            }

            try
            {
                _categoryRepo.Remove(obj);
                _categoryRepo.Save();
                TempData["success"] = "Category Deleted Successfully";
            }
            catch (Exception ex)
            {
               
                TempData["error"] = "Category Deletion Failed."; 
            }

            return RedirectToAction("Index", "Category");
        }
    }
}