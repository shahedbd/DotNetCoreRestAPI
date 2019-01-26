using DotNetCoreRestAPI.LIB;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace DotNetCoreRestAPI.Controllers
{
    [Route("api/auth")]
    public class AuthController : Controller
    {
        private IAuth _iauth;
        public AuthController(IAuth iauth)
        {
            _iauth = iauth;
        }
        // GET api/values
        [HttpPost, Route("login")]
        public IActionResult Login([FromBody]LoginInfo user)
        {
            if (user == null)
            {
                return BadRequest("Invalid client request");
            }

            if (user.UserName == "johndoe" && user.Password == "def@123")
            {
                //var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));
                //var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

                //var tokeOptions = new JwtSecurityToken(
                //    issuer: "http://localhost:5000",
                //    audience: "http://localhost:5000",
                //    claims: new List<Claim>(),
                //    expires: DateTime.Now.AddMinutes(5),
                //    signingCredentials: signinCredentials
                //);

                //var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
                return Ok(new { Token = _iauth.GenerateJSONWebToken() });
            }
            else
            {
                return Unauthorized();
            }
        }
    }
}