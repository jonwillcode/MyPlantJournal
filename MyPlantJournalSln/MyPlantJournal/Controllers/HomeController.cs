using Microsoft.AspNetCore.Mvc;
using MyPlantJournal.Models;

namespace MyPlantJournal.Controllers
{
    public class HomeController : Controller
    {
        private IPlantJournalRepository _plantJournalRepository;
        public int PageSize = 4;
        public HomeController(IPlantJournalRepository plantJournalRepository)
        {
            _plantJournalRepository = plantJournalRepository;
        }
        public IActionResult Index(int plantPage = 1) => View(
                _plantJournalRepository.Plants
                .OrderBy(p => p.Name)
                .Skip((plantPage - 1) * PageSize)
                .Take(PageSize)
            );
    }
}
