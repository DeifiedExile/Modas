using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Modas.Models;

namespace Modas.Controllers
{
public class HomeController : Controller
{
private IEventRepository repository;
public HomeController(IEventRepository repo)
{
repository = repo;
}

//configure to eagerly load location data
public ViewResult Index() => View(
    repository.Events.Include(e => e.Location).OrderBy(e => e.TimeStamp));
    }
}