using LibraryApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApp.Interface;

public interface IAccountService
{
    Task<(bool, string)> Login (User model);

}