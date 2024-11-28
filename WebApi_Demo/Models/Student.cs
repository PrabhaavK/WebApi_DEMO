using System;
using Microsoft.EntityFrameworkCore;

namespace WebApi_Demo.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string StudentDOB { get; set; }
        public string StudentPhoneNum { get; set; }
        public string studentAddress { get; set; }
        public int CourseID { get; set;}
    }
}
