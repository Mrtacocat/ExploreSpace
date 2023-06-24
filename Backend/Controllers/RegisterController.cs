using Microsoft.AspNetCore.Mvc;
using Backend.Models;

namespace Backend.Controllers
{
    [Route("api/register")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly AccDataAccess _dataAccess;

        public RegisterController(AccDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        [HttpPost]
        public ActionResult Register(UserModel user)
        {
            var storedUser = _dataAccess.GetUserByUsername(user.Username);

            if (storedUser != null)
            {
                return BadRequest("Username already exists");
            }

            _dataAccess.RegisterUser(user);
            return Ok();
        }
    }
}
