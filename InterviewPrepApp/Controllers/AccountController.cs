using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using InterviewPrepApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace InterviewPrepApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IConfiguration _config;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _config = configuration;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(AccountDTO register)
        {
            ApplicationUser user = new ApplicationUser()
            {
                UserName = register.Username
            };

            var result = await _userManager.CreateAsync(user, register.Password);

            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, register.Persistent);
                var token = CreateToken(user, new List<string>() { "Basic" });
                return Ok(new
                {
                    role = "",
                    jwt = new JwtSecurityTokenHandler().WriteToken(token),
                    expiration = token.ValidTo
                });
            }

            return BadRequest("Invalid registration");
        }

        [AllowAnonymous]
        [HttpPost("Login")]
        public async Task<IActionResult> Login(AccountDTO login)
        {
            var result = await _signInManager.PasswordSignInAsync(login.Username, login.Password, login.Persistent, false);

            if (result.Succeeded)
            {
                var user = await _userManager.FindByNameAsync(login.Username);
                var identityRole = await _userManager.GetRolesAsync(user);
                var token = CreateToken(user, identityRole.ToList());

                

                return Ok(new
                {
                    role = identityRole.ToList()[0],
                    jwt = new JwtSecurityTokenHandler().WriteToken(token),
                    expiration = token.ValidTo
                });
            }
            return BadRequest("Invalid login attempt");
        }

        private JwtSecurityToken CreateToken(ApplicationUser appUser, List<string> role)
        {
            // Token needs info called "Claims" which tell something True abou the user. I.e. I have red hair, my name is Nicholas, etc..
            // A User is the "principle" and can have many forms of "identity" containing these claims i.e. birth cert, drivers license, SSN, etc...
            var authClaims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, appUser.UserName),
                // Optional:
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim("UserName", appUser.UserName),
                new Claim("UserId", appUser.Id),
            };

            foreach (var item in role)
            {
                authClaims.Add(new Claim(ClaimTypes.Role, item));
            }
            var token = AuthenticateToken(authClaims);
            return token;
        }

        private JwtSecurityToken AuthenticateToken(List<Claim> claims)
        {
            var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JWTKey"]));

            var token = new JwtSecurityToken(
                issuer: _config["JWTIssuer"],
                expires: DateTime.UtcNow.AddHours(24),
                claims: claims,
                signingCredentials: new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256)
                );
            return token;
        }
    }

    public class AccountDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Persistent { get; set; }
    }
}
