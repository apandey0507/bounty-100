using Microsoft.AspNetCore.Mvc;
using User.Service.DTO;

namespace User.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public IConfiguration config;
        public UserController(IConfiguration _config)
        {
            this.config = _config;
        }
        [HttpGet]
        public string GetUsers()
        {
            var tempVariable = this.config.GetSection("AllowedHosts").Value;
            Console.WriteLine(tempVariable);
            return tempVariable;
        }

        [HttpPost]
        public string RegisterUser(UserDto userDto)
        {
            return (Environment.GetEnvironmentVariable("MONGO_CONNECTION_STRING", EnvironmentVariableTarget.Process));

        }
    }
}
