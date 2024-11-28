
// using System;
// //dotnet new controller -name MyController -output ./Controllers
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;
// using WebApi_Demo.Models;

// namespace MyWebApi.Controllers
// {
//     [ApiController]
//     [Route("[controller]")]
//     public class StudentController : ControllerBase
//     {
//         private readonly AppDbContext _context;

//         public StudentController(AppDbContext context)
//         {
//             _context = context;
//         }

//         [HttpGet]
//         public IActionResult GetStudent()
//         {
//             var studlist = _context.Students.ToList();
//             if(studlist.Count != 0)
//             {
//                 return Ok(studlist);
//             }
//             else
//             {
//                 return BadRequest();
//             }
//         }

//         [HttpGet("id")]
//         public IActionResult GetAllStudents(int Id)
//         {
//             var  data = _context.Students.FirstOrDefault(x => x.Id == Id);
//             if(data == null)
//             {
//                 return NotFound();
//             }
//             else
//             {
//                 return Ok(data);
//             }
//             return Ok(_students);
//         }
//     }
// }
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi_Demo.Models;

namespace MyWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly AppDbContext _context;

        public StudentController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("GetStudent")]
        public IActionResult GetStudents()
        {
            var students = _context.Students.ToList();
            return students.Any() ? Ok(students) : NotFound();
        }

        [HttpGet("{id}")]
        public IActionResult GetStudentById(int id)
        {
            var student = _context.Students.Find(id);
            return student != null ? Ok(student) : NotFound();
        }
    }
}