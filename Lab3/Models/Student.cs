using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Lab3.Models
{
    public class Student
    {
        [Required]
        [BindProperty(Name = "firstName")]
        public string FName
        {
            get;
            set;
        }


        [Required]
        [BindProperty(Name = "lastName")]
        public string LName
        {
            get;
            set;
        }

        [Required]
        [EmailAddress]
        [BindProperty(Name = "email")]
        public string Email
        {
            get;
            set;
        }

        [Required]
        [BindProperty(Name = "id")]
        public string Id
        {
            get;
            set;
        }

        [Required]
        [BindProperty(Name = "description")]
        public string Desc
        {
            get;
            set;
        }

    }
}
