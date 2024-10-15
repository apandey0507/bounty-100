

using Microsoft.Extensions.DependencyInjection;
using User.Service.Repository;
using User.Service.Repository.Interfaces;
using User.Service.Service;
using User.Service.Service.Interfaces;

namespace User.Service.Extension
{
    public static class UserExtension{
        public static void AddUserDependencies(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IUserService, UserService>();
            serviceCollection.AddScoped<IUserRepository, UserRepository>();
        }
    }
}


