using System.ComponentModel.DataAnnotations;

namespace BookAuthors.Models
{
    public class BookAuthorModel
    {
        [Key]
        public int id{get;set;}
        [Required]
        [Display(Name = "First Name")]
        public string fName{get;set;}
        [Required]
        [Display(Name = "Last Name")]
        public string lName{get;set;}
        public bool isActive{get;set;}
    }
}