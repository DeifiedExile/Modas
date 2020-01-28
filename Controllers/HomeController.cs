using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Modas.Models;

namespace Modas.Controllers
{
    public class HomeController : Controller
    {
        private readonly int PageSize = 15;
        private IEventRepository repository;
        public HomeController(IEventRepository repo)
        {
            repository = repo;
        }
        
        public ViewResult Index(int page = 1) => View(
            repository.Events.Include(e => e.Location)
                .OrderBy(e => e.TimeStamp)
                .Skip((page - 1) * PageSize)
                .Take(PageSize));
    }
}