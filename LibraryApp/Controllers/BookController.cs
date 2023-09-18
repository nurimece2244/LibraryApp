using LibraryApp.Data;
using LibraryApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.Controllers;

public class BookController : Controller
{
    private readonly ApplicationDbContext _dbContext;

    public BookController(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    [HttpGet]
    public IActionResult AddBook()
    {
        return View();
    }
    
    [HttpGet]
    public async Task<IActionResult> ListBook()
    {
        var books = await _dbContext.Book.OrderBy(x => x.Name).ToListAsync();
        return View(books);
        
    }

    [HttpPost]
    public async Task<IActionResult> AddBook(Book model)
    {
        var existBook = await _dbContext.Book.FirstOrDefaultAsync(u => u.Name == model.Name);
        if (existBook != null)
        {
            ModelState.AddModelError(string.Empty, "Eklenen kitap bir daha eklenemez!");
            return View(model);
        }
    
        using var memoryStream = new MemoryStream();
        await model.ImageFile.CopyToAsync(memoryStream);

        var book = new Book()
        {
            Author = model.Author,
            Name = model.Name,
            IsActive = model.IsActive,
            Image = memoryStream.ToArray() // Burada Image özelliğini kullanıyoruz
        };
    
        _dbContext.Book.Add(book);
        await _dbContext.SaveChangesAsync();
    
        return View(model);
    }
    
    [HttpPost]
    public async Task<IActionResult> LendBook(Book model)
    {
        var existBook = await _dbContext.Book.FirstOrDefaultAsync(u => u.Name == model.Name);
        if (existBook != null)
        {
            ModelState.AddModelError(string.Empty, "Eklenen kitap bir daha eklenemez!");
            return View(model);
        }
    
        using var memoryStream = new MemoryStream();
        await model.ImageFile.CopyToAsync(memoryStream);

        var book = new Book()
        {
            Author = model.Author,
            Name = model.Name,
            IsActive = model.IsActive,
            Image = memoryStream.ToArray() // Burada Image özelliğini kullanıyoruz
        };
    
        _dbContext.Book.Add(book);
        await _dbContext.SaveChangesAsync();
    
        return View(model);
    }

    
    
}