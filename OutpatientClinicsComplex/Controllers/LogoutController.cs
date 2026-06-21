using Microsoft.AspNetCore.Mvc;
using OutpatientClinicsComplex.Models;
using OutpatientClinicsComplex.DTOs;

namespace OutpatientClinicsComplex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogoutController : ControllerBase
    {
        private readonly OutpatientClinicsComplexContext _context;

        public LogoutController(OutpatientClinicsComplexContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Logout([FromBody] LogoutRequest request)
        {
            return Ok(new { message = $"User {request.Code} ({request.Role}) logged out successfully" });
        }
    }
}
