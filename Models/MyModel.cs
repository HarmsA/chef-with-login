using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace newlogin.Models
{
    public class User
    {
        [Key]
        public int UserId {get;set;}
        [Required]
        [DisplayName("First Name")]
        public string Fname {get;set;}
        [Required]
        [DisplayName("First Name")]
        public string Lname {get;set;}
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email {get;set;}

        [DisplayName("Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{dd/MM/YYYY}")]
        public DateTime DOB {get;set;}
        
        [DataType(DataType.Password)]
        [Required]
        public string Password {get;set;}

        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string Confirm {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public List<Post> Dishlist {get;set;}
    }

        public class LoginUser
    {
        [Required]
        [EmailAddress]
        [DisplayName("Email")]
        [DataType(DataType.EmailAddress)]
        public string LogEmail {get;set;}

        [DataType(DataType.Password)]
        [DisplayName("Password")]
        [Required]
        public string LogPassword {get;set;}
    }
}