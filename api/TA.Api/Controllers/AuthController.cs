using TA.Application.Response;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TA.Api.Authentication;
using TA.Domain.DBModel;
using TA.Domain.Model;

namespace TA.Api.Controllers
{
    public class AuthController : BaseController
    {
        private readonly TokenHelper _jwtExt;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AuthController(
            TokenHelper jwtExt,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager
            )
        {
            _jwtExt = jwtExt;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpPost]
        [Route("Registration")]
        public async Task<IActionResult> Register(RegisterModel registerModel)
        {
            var userModel = new ApplicationUser()
            {
                Name = registerModel.Name,
                SurName = registerModel.Name,
                Email = registerModel.Email,
                UserName = registerModel.Email,
                PasswordHash = registerModel.Password,
                Status = 1
            };
            var user = await _userManager.FindByNameAsync(registerModel.Email);

            if (user != null)
            {
                await _userManager.AddToRoleAsync(user, Application.Enum.Role.User.ToString());
            }
            else
            {
                try
                {
                    var result = await _userManager.CreateAsync(userModel, registerModel.Password);
                    if (!result.Succeeded)
                    {
                        var errors = result.Errors.Select(x => x.Description).ToList();
                        return BadRequest(new AuthResponse() { Errors = errors });
                    }
                    //await _userManager.AddToRoleAsync(userModel, Application.Enum.Role.User.ToString());
                }
                catch (Exception ex)
                {
                    //var insertedUser = _userManager.Users.FirstOrDefault(x => x.Email == registerModel.Email);
                    var insertedUser = await _userManager.FindByNameAsync(registerModel.Email);
                    await _userManager.DeleteAsync(user);
                    throw;
                }
            }
            return Ok();
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] LoginModel loginModel)
        {
            var result = await _signInManager.PasswordSignInAsync(loginModel.Email, loginModel.Password,true,false);
            if (!result.Succeeded)
            {
                return BadRequest();
            }

            var user = await _userManager.FindByNameAsync(loginModel.Email);

            if (user == null || user.Status == 0) return BadRequest();

            var userRoles = await _userManager.GetRolesAsync(user);

            var token = await _jwtExt.GetToken(user, userRoles);
            return Ok(new LoginResponse()
            {
                Token = token,
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                Role = string.Join(",",userRoles.ToList())
            });
        }
    }
}
