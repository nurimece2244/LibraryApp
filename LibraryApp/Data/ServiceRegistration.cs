using LibraryApp.Data.Services;
using LibraryApp.Interface;

namespace LibraryApp.Data;

public static class ServiceRegistration
{
    public static void AddPersistanceLayer (this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped< IAccountService, AccountService>();
        serviceCollection.AddScoped< IBookService, BookService>();


    }
}