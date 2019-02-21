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
        [RegularExpression(@"(S|s)\d{7}", ErrorMessage="The ID should have a letter S and 7 digits")]
        public string StudentID { get; set; } = "";
        [Required(ErrorMessage = "Please  Enter Your First Name")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = "";
        [Required(ErrorMessage = "Please  Enter Your Last Name")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = "";
        [Required(ErrorMessage = "Please  Enter A Phone Number")]
        [RegularExpression(@"0\d{9}", ErrorMessage = "The Phone Number should have the format 0XXXXXXXXX Whitout spaces")]
        public string PhoneNumber { get; set; } = "";


    }
}
