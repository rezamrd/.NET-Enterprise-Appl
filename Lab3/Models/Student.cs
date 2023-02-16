using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Lab3.Models
{
    public class Student
    {
        [Required]
        public string? FName
        {
            get;
            set;
        }


        [Required]
        public string? LName
        {
            get;
            set;
        }

        [Required]
        [EmailAddress]
        public string? Email
        {
            get;
            set;
        }

        [Required]
        public string? Id
        {
            get;
            set;
        }

        [Required]
        public string? Desc
        {
            get;
            set;
        }

    }
}
