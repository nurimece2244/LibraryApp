using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryApp.Models;

public class Book
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Author { get; set; } = null!;
    public byte[] Image { get; set; } 
    
    [NotMapped]
    public IFormFile ImageFile  { get; set; }
    public bool IsActive { get; set; }
    
    public LendBook LendBook { get; set; }
}