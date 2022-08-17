//-----------------------------------------------
// Proyect: EFChallenge 
// Developers: Christian Alvarado 
// Company:  Unosquare 2022
//-----------------------------------------------

using EFChallenge.Services.Interfaces;
using EFChallenge.Services.Services;
using Microsoft.Extensions.DependencyInjection;


namespace EFChallenge.Services.DI
{
    /// <summary>
    /// Serivice Dependecy Injection 
    /// The functionality of this class is not register one by one in program.cs
    /// and to have a cleaner code
    /// </summary>
    public static class ServiceDI
    {
        /// <summary>
        /// Register  services by Dependency injection
        /// </summary>
        /// <param name="serviceCollection">a service collection</param>
        public static IServiceCollection RegisterDI(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<ICompanyService, CompanyService>();
            serviceCollection.AddScoped<IItemService, ItemService>();
            return serviceCollection;
        }
    }
}
