using Microsoft.AspNetCore.Mvc;
using MyPieShop.Models;
using MyPieShop.ViewModels;

namespace MyPieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        // Create using constructor injection 
        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        // Create action method
        public ActionResult List()
        {
            // ViewBag.CurrentCategory = "Cheese cakes";
            // return View(_pieRepository.AllPies);
            PieListViewModel piesListViewModel = new PieListViewModel(_pieRepository.AllPies, "Cheese cakes");

            return View(piesListViewModel);

        }
    }
}
