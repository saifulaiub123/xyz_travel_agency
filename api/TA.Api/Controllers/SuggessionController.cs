using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TA.Api.Authentication;
using TA.Application.IService;
using TA.Application.Response;
using TA.Domain.DBModel;
using TA.Domain.Model;

namespace TA.Api.Controllers
{
    public class SuggessionController : BaseController
    {
        private readonly TokenHelper _jwtExt;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ISuggessionService _suggessionService;

        public SuggessionController(
            TokenHelper jwtExt,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ISuggessionService suggessionService)
        {
            _jwtExt = jwtExt;
            _userManager = userManager;
            _signInManager = signInManager;
            _suggessionService = suggessionService;
        }

        [HttpPost]
        [Route("SubmitSuggession")]
        public async Task<IActionResult> Register(SuggessionModel model)
        {
            await _suggessionService.SubmitSuggession(model);
            return Ok();
        }
    }
}
