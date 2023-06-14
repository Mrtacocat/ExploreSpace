using Backend.DataAccess;
using Backend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegisterController : ControllerBase
    {
        private readonly AccountDataAccess _accountDataAccess;

        public RegisterController(AccountDataAccess accountDataAccess)
        {
            _accountDataAccess = accountDataAccess;
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserModel user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await _accountDataAccess.CreateUser(user);
                return Ok("User registered successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}