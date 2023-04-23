using BethanysPieShop.Models;
using BethanysPieShop.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controller
{
    public class PieController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
           /* ViewBag.CurrentCategory = "Cheese cakes";
            return View(_pieRepository.AllPies);*/
           PieListViewModel piesListViewModel = new PieListViewModel(
               _pieRepository.AllPies, "Cheese cakes");
           return View(piesListViewModel);
        }
    }
}
