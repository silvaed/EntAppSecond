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
        [RegularExpression(@"\D{2,}", ErrorMessage = "First Name should have at least 2 characters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = "";
        [Required(ErrorMessage = "Please  Enter Your Last Name")]
        [Display(Name = "Last Name")]
        [RegularExpression(@"\D{3,}", ErrorMessage = "First Name should have at least 2 characters")]
        public string LastName { get; set; } = "";
        [Required(ErrorMessage = "Please  Enter A Phone Number")]
        [RegularExpression(@"0\d{9}", ErrorMessage = "The Phone Number should have the format 0XXXXXXXXX Whitout spaces")]
        public string PhoneNumber { get; set; } = "";
        [Required(ErrorMessage = "Please  Enter A Date")]
        [Display(Name = "Birth Date")]
        //[RegularExpression(@"0\d{9}", ErrorMessage = "Date of Birth is Required")]
        public DateTime DateOfBirth { get; set; }
        [Required(ErrorMessage = "Please  Enter the number of modules taken")]
        [Display(Name = "Number of Modules")]
        [RegularExpression(@"[2-9]|1[0]", ErrorMessage = "The number of modules should be greater  that 1")]
        public int NUmberOfModules { get; set; }
        [Required(ErrorMessage = "Please  Enter your Height in Cm")]
        [Display(Name = "Height (CM)")]
        [RegularExpression(@"[5-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|2[5][0]", ErrorMessage = "Number between 50 and 250")]
        public double HeightCm { get; set; }
        [Required(ErrorMessage = "This is not a valid e-mail format")]
        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "This is not a valid e-mail format")]
        [Display(Name = "E-mail Confirmation")]
        [DataType(DataType.EmailAddress)]
        public string EmailCheck { get; set; }






    }
}
