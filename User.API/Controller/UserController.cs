using Microsoft.AspNetCore.Mvc;
using User.Service.DTO;

namespace User.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public string GetUsers()
        {
            return "server started";
        }

        [HttpPost]
        public string RegisterUser(UserDto userDto)
        {
            return "server started";
        }
    }
}
