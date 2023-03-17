using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Engineers.Generic;
using System.Linq;

namespace Factory.Controllers
{
  public class HomeController : Controller
  {
    private readonly FactoryContext _db;
    public HomeController(FactoryContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      Machine[] machines = _db.Machines.ToArray(); // if this doesn't work, rename machines
      Engineer[] engineers = _db.Engineers.ToArray();
      Dictionary<string, object[]> model = new Dictionary<string, object[]>();
      model.Add("machines", machines);
      model.Add("engineers", engineers);
      return View(model);
    }
  }
}