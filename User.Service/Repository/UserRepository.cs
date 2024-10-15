using User.Service.Repository.Interfaces;

namespace User.Service.Repository
{
    public class UserRepository: IUserRepository
    {
        public UserRepository() {
            Console.WriteLine(Environment.GetEnvironmentVariable("MONGO_CONNECTION_STRING", EnvironmentVariableTarget.Process ));
        }
    }
}
