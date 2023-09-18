namespace LibraryApp.Models;

public class LendBook
{
    public int Id { get; set; } 
    
    public int BookId { get; set; }
    
    public string BarrowName { get; set; } = null!;
    
    public string BarrowSurname { get; set; } = null!;
    
    public DateTime EndDate { get; set; } 
    
    public Book? Book { get; set; }

}