using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntAppSecond.Pages
{
    public class FormWsModel : PageModel
    {
        [BindProperty]
        public string Message { get; set;}

        [BindProperty]
        [Display(Name = "Product Code")]
        public string ProductCode { get; set; } 

        [BindProperty]
        public string Color { get; set; }

        [BindProperty]
        [Display(Name = "I consent with everything")]
        public bool Consent { get; set; }



        public void OnGet()
        {
            Message = $"You Selected the Get {ProductCode} and Color is {Color}";
        }

        public void OnPost()
        {

            Message = $"You Selected the Product Code {ProductCode} and Color is {Color}";

        }
    }
}