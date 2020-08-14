using Microsoft.AspNetCore.Mvc;
using SweetAndSavory.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace SweetAndSavory.Controllers
{
  public class FlavorsController : Controller
  {
    private readonly SweetAndSavoryContext _db;
    public FlavorsController(SweetAndSavoryContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Flavor> model = _db.Flavors.ToList();
      return View(model);
    }
    public ActionResult Create()
    {
      return View();
    }
    [HttpPost]
    public ActionResult Create(Flavor flavor)
    {
      _db.Flavors.Add(flavor);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    [Authorize]
    public ActionResult Details(int id)
    {
      var thisFlavor = _db.Flavors
        .Include(flavor => flavor.Treats)
        .ThenInclude(join => join.Treat)
        .FirstOrDefault(flavors => flavors.FlavorId == id);
      return View(thisFlavor);
    }
    public ActionResult AddTreat(int id)
    {
      var thisFlavor = _db.Flavors
      .Include(flavor => flavor.Treats)
      .ThenInclude(join => join.Treat)
      .FirstOrDefault(flavors => flavors.FlavorId == id);
      return View(thisFlavor);
    }
    [HttpPost]
    public ActionResult AddTreat(Flavor flavor)
    {
      var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
      if (userId != null)
      {
        _db.TreatFlavor.Add(new TreatFlavor() { TreatId = userId, FlavorId = flavor.FlavorId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    [HttpPost]
    public ActionResult DeleteTreat()
    {
      var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
      var joinEntry = _db.TreatFlavor.FirstOrDefault(entry => entry.TreatId == userId);
      _db.TreatFlavor.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    [HttpPost]
    public ActionResult Edit(Flavor flavor)
    {
      _db.Entry(flavor).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult edit(int id)
    {
      var thisFlavor = _db.Flavors
      .Include(Flavor => Flavor.Treats)
    }
  }
}