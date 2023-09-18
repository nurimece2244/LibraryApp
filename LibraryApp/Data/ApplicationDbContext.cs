using LibraryApp.Models;
namespace LibraryApp.Data;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    
    public DbSet<User> User { get; set; }
    public DbSet<Book> Book { get; set; }
    public DbSet<LendBook> LendBook { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    
  
}
