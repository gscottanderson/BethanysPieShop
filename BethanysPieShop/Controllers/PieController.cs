using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            var list = new PiesListViewModel()
            {
                CurrentCategory = "Cheese Cakes",
                Pies = _pieRepository.Pies
            };

            return View(list);
        }
    }
}