using EDMSolution.Application.System.Users;
using EDMSolution.ViewModels.System.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDMSolution.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginsController : ControllerBase
    {
        private readonly IUserService _userService;
        public LoginsController(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<IActionResult> Authenticate([FromForm] LoginRequest request)
        {
            var resultToken = _userService.Authencate(request);
        }

    }
}
