using LibraryApp.Interface;
using LibraryApp.Models;
using Microsoft.AspNetCore.Mvc;


namespace LibraryApp.Controllers;

public class AccountController : Controller
{
    private readonly IAccountService _accountService;

    public AccountController(IAccountService accountService)
    {
        _accountService = accountService;
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

        var user = await _accountService.Login(model);
        if (user.Item1 == false)
        {
            ModelState.AddModelError(string.Empty, "Geçersiz giriş denemesi.");
            return View(model);
        }

        return RedirectToAction("ListBook", "Book");
    }
}