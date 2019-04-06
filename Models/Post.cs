using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace newlogin.Models
{
    public class Post
    {
        // [Key]
        public int PostId {get;set;}

        [Required]
        [DisplayName("Name of Dish")]
        public string Dish {get;set;}

        [Required]
        [DisplayName("# of Calories")]
        public int Calories {get;set;}

        [Required]
        [DisplayName("Tastiness")]

        public int Taste {get;set;}
        
        [Required]
        public string Description {get;set;}


        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        public int UserId {get;set;}
        public User Chef {get;set;}
    }

}