using LibraryApp.Models;

namespace LibraryApp.Interface;

public interface IBookService
{
    Task<List<Book>> ListBook ();
    
    Task LendBook ( LendBook model );
    
    Task<(bool, string)> AddBook ( Book model );
}