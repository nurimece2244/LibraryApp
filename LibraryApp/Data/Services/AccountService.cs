using LibraryApp.Interface;
using LibraryApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.Data.Services;

public class AccountService: IAccountService
{
    private readonly ApplicationDbContext _dbContext;

    public AccountService (ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<(bool, string)> Login(User model)
    {

        var user = await _dbContext.User.FirstOrDefaultAsync(u => u.Username == model.Username);
        if (user == null)
        {
            return (false, "Kullanıcı bulunamadı"); 
        }

        if (model.Password == user.Password )
        {

            return (true, "Hoşgeldiniz"); 
        }
        
        return (false, "Kullanıcı adı veya parola yanlış"); 
        
    }
    
}
