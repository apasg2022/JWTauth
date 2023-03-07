using JWTToken.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWTToken.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        [Route("GetData")]
        public string GetData()
        {
            return "Authenticate with Jwt";
        }

        [Authorize]
        [HttpPost]
        public string AddUser(Users user)
        {
            return "user added" + user.Username;vbvbcvbvb
        }
    }
}
