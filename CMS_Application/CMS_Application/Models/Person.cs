using CMS_Application.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CMS_Applicaion.Models
{
    public enum PersonType
    {
        Student, Teacher, Admin
    }
    public class Person
    {
        public int Id { get; set; }

        public LoginStrategy strategy{ get; set; }
        public Person()
        {
        }
        public Person(LoginStrategy strategy)
        { 
            this.strategy = strategy;
        }
        [Required(ErrorMessage = "Please enter your correct Id")]
        [Display(Prompt = "Enter User Id")]
        public string UserId { get; set; }
        [MinLength(8, ErrorMessage = "Please enter minimum 8 letters")]
        [DataType(DataType.Password)]
        [Display(Prompt = "Enter Password")]
        [Required(ErrorMessage = "Please enter Password")]
        public string Password { get; set; }
        [Display(Prompt = "Enter Name")]
        public string Name { get; set; }
        [Display(Prompt = "Enter Address")]
        public string Address { get; set; }
        [Display(Prompt = "Enter Phone Number")]
        public string PhoneNo { get; set; }
    }
}
