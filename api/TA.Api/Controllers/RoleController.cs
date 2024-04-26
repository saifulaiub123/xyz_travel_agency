using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TA.Application.Enum;
using TA.Application.Response;
using TA.Domain.DBModel;
using TA.Domain.Model;

namespace TA.Api.Controllers
{
    [Authorize]
    public class RoleController : BaseController
    {
        private readonly RoleManager<Domain.DBModel.Role> _roleManager;
        public RoleController(RoleManager<Domain.DBModel.Role> roleManager) 
        { 
            _roleManager= roleManager;
        }

        [HttpGet]
        [Route("GetRoles")]
        public async Task<IActionResult> GetRoles()
        {
            var roles = await _roleManager.Roles.ToListAsync();
            return Ok(roles);
        }
    }
}
