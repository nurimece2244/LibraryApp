using LibraryApp.Data;
using LibraryApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.Controllers;

public class AccountController : Controller
{
    private readonly ApplicationDbContext _dbContext;

    public AccountController(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Login(User model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        var user = await _dbContext.User.FirstOrDefaultAsync(u => u.Username == model.Username);
        if (user == null)
        {
            ModelState.AddModelError(string.Empty, "Geçersiz giriş denemesi.");
            return View(model);
        }

        if (model.Password == user.Password )
        {
            // Kullanıcının oturumunu başlat
            // Örneğin, oturum bilgisini bir cookie'ye ya da session'a kaydedebilirsiniz.

            return RedirectToAction("ListBook", "Book");
        }

        ModelState.AddModelError(string.Empty, "Geçersiz giriş denemesi.");
        return View(model);
    }
    
}
