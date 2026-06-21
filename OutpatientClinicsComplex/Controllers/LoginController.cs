using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OutpatientClinicsComplex.Models;
using OutpatientClinicsComplex.DTOs;

namespace OutpatientClinicsComplex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly OutpatientClinicsComplexContext _context;

        // ✅ قائمة الأدوار الصحيحة (المسموح بها فقط)
        private readonly List<string> _validRoles = new()
        {
            "doctor",
            "pharmacist",
            "receptionist",
            "labtechnician"
        };

        public LoginController(OutpatientClinicsComplexContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            // 1. التحقق من وجود الـ Role
            if (string.IsNullOrEmpty(request.Role))
                return BadRequest(new { message = "الرجاء اختيار الدور من القائمة المنسدلة." });

            // 2. ❌ منع الكتابة: التأكد أن الـ Role من القائمة المنسدلة فقط
            if (!_validRoles.Contains(request.Role.ToLower()))
                return BadRequest(new
                {
                    message = "يُسمح فقط بالاختيار من القائمة المنسدلة. الكتابة غير مسموحة.",
                    validRoles = new[] { "Doctor", "Pharmacist", "Receptionist", "LabTechnician" }
                });

            int? userCode = null;
            string role = request.Role;

            // 3. البحث في الجدول المناسب حسب الـ Role
            switch (request.Role.ToLower())
            {
                case "doctor":
                    var doctor = await _context.Doctors
                        .FirstOrDefaultAsync(d => d.Code == request.Code && d.Password == request.Password);
                    if (doctor != null)
                        userCode = doctor.Code;
                    break;

                case "pharmacist":
                    var pharmacist = await _context.Pharmacists
                        .FirstOrDefaultAsync(p => p.Code == request.Code && p.Password == request.Password);
                    if (pharmacist != null)
                        userCode = pharmacist.Code;
                    break;

                case "receptionist":
                    var receptionist = await _context.Receptionists
                        .FirstOrDefaultAsync(r => r.Code == request.Code && r.Password == request.Password);
                    if (receptionist != null)
                        userCode = receptionist.Code;
                    break;

                case "labtechnician":
                    var labTech = await _context.LabTechnicians
                        .FirstOrDefaultAsync(l => l.Code == request.Code && l.Password == request.Password);
                    if (labTech != null)
                        userCode = labTech.Code;
                    break;
            }

            // 4. التحقق من صحة الكود والباسوورد
            if (userCode == null)
                return Unauthorized(new { message = "كود المستخدم أو كلمة المرور غير صحيحة للدور المختار." });

            // 5. إنشاء الـ Response
            var response = new LoginResponse
            {
                Message = $"تم تسجيل الدخول بنجاح كـ {role}",
                Code = userCode.Value,
                Role = role
            };

            return Ok(response);
        }
    }
}