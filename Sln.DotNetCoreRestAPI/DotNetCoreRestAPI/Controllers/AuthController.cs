using DotNetCoreRestAPI.LIB;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreRestAPI.Controllers
{
    [Route("api/auth")]
    //[Route("api/v1/[controller]")]
    public class AuthController : Controller
    {
        private IAuth _iauth;
        public AuthController(IAuth iauth)
        {
            _iauth = iauth;
        }

        // GET api/values
        [HttpPost, Route("login")]
        //[HttpPost]
        public IActionResult Login([FromBody]LoginInfo user)
        {
            if (user == null)
            {
                return BadRequest("Invalid client request");
            }
            int ExpireIn = 5;
            if (user.UserName == "johndoe" && user.Password == "def@123")
            {
                var tokenString = _iauth.GenerateJSONWebToken(ExpireIn);
                return Ok(new { Token = tokenString, ExpireTime = ExpireIn * 60, RefreshToken = _iauth.GenerateRefreshToken() });
            }
            else
            {
                return Unauthorized();
            }
        }
    }
}