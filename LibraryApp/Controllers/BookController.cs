using LibraryApp.Interface;
using LibraryApp.Models;
using Microsoft.AspNetCore.Mvc;


namespace LibraryApp.Controllers;

public class BookController : Controller
{
    private readonly IBookService _bookService;

    public BookController(IBookService bookService)
    {
        _bookService = bookService;
    }

    [HttpGet]
    public async Task<IActionResult> ListBook()
    {
        var books = await _bookService.ListBook();

        return View(books);
    }

    [HttpGet]
    public IActionResult LendBook(int id)
    {
        var lendBookViewModel = new LendBook { BookId = id };
        return View(lendBookViewModel);
    }


    [HttpPost]
    public async Task<IActionResult> LendBook(LendBook model)
    {
        await _bookService.LendBook(model);

        return RedirectToAction("ListBook");
    }


    [HttpGet]
    public IActionResult AddBook()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> AddBook(Book model)
    {
        await _bookService.AddBook(model);

        return RedirectToAction("ListBook");
    }
}