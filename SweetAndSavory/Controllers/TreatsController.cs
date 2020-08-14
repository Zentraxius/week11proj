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
    private readonly SignInManager<Treat> _signInManager;

    public TreatsController(UserManager<Treat> userManager, SignInManager<Treat> signInManager, SweetAndSavoryContext db)
    {
      _userManager = userManager;
      _signInManager = signInManager;
      _db = db;
    }

    public ActionResult Index()
    {
      return View();
    }

    // public IActionResult Register()
    // {
    //   return View();
    // }

    // [HttpPost]
    // public async Task<ActionResult> Register(RegisterViewModel model)
    // {
    //   var user = new Treat { UserName = model.Email };
    //   IdentityResult result = await _userManager.CreateAsync(user, model.Password);
    //   if (result.Succeeded)
    //   {
    //     return RedirectToAction("Index");
    //   }
    //   else
    //   {
    //     return View();
    //   }
    // }

    // public ActionResult Login()
    // {
    //   return View();
    // }

    // [HttpPost]
    // public async Task<ActionResult> Login(LoginViewModel model)
    // {
    //   Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: true, lockoutOnFailure: false);
    //   if (result.Succeeded)
    //   {
    //     return RedirectToAction("Index");
    //   }
    //   else
    //   {
    //     return View();
    //   }
    // }

    // [HttpPost]
    // public async Task<ActionResult> LogOff()
    // {
    //   await _signInManager.SignOutAsync();
    //   return RedirectToAction("Index");
    // }

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