using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentApi.Data;
using StudentApi.Models;

namespace StudentApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly CollegeContext _context;

        public StudentController(CollegeContext context)
        {
            _context = context;
        }

        // Q3: Insert new student
        [HttpPost]
        public async Task<IActionResult> AddStudent(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
            return Ok(student);
        }

        [HttpGet]
        public async Task<IActionResult> GetStudents()
        {
            var students = await _context.Students.ToListAsync();
            return Ok(students);
        }

        [HttpPut("{id}/email")]
        public async Task<IActionResult> UpdateEmail(int id, [FromBody] string newEmail)
        {
            var student = await _context.Students.FindAsync(id);
            if (student == null) return NotFound("Student not found");

            student.Email = newEmail;
            await _context.SaveChangesAsync();

            return Ok(student);
        }
    }
}
