using Microsoft.Extensions.DependencyInjection

public class UserExtension
{
  public static void AddUserDependencies(this IServiceCollection serviceCollection ){  
  builder.Services.AddScoped<IUserService, UserService>();
  builder.Services.AddScoped<IUserRepository, UserRepository>();
  }
}