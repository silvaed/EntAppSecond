using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; // This is important to the validation process // test

namespace EntAppSecond.Models
{
    public class Student
    {
        [Required (ErrorMessage ="Please  Enter A Student ID")]
        public string StudentID { get; set; } = "";
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = "";

        public string LastName { get; set; } = "";

    }
}
