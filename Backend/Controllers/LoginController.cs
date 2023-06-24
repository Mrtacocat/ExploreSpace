using Microsoft.AspNetCore.Mvc;
using Backend.Models;

namespace Backend.Controllers
{
    [Route("api/login")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly AccDataAccess _dataAccess;

        public LoginController(AccDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        [HttpPost]
        public ActionResult<UserModel> Login(UserModel user)
        {
            var storedUser = _dataAccess.GetUserByUsername(user.Username);

            if (storedUser == null || storedUser.Password != user.Password)
            {
                return BadRequest("Invalid username or password");
            }

            return storedUser;
        }
    }
}
