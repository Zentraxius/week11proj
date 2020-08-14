using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using SweetAndSavory.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;
using SweetAndSavory.ViewModels;


namespace SweetAndSavory.Controllers
{
  public class TreatsController : Controller
  {
    private readonly SweetAndSavoryContext _db;
    private readonly UserManager<Treat> _userManager;

    public TreatsController(UserManager<AppUser> userManager, SweetAndSavoryContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    public ActionResult Index()
    {
      List<Treat> model = _db.Engineers.ToList();
      return View();
    }
    public ActionResult Details(int id)
    {
      var thisTreat = _db.Treats
        .Include(treat => treat.Flavors)
        .ThenInclude(join => join.Flavor)
        .FirstOrDefault(treat => treat.TreatId == id);
      return View(thisTreat);
    }
  }
}