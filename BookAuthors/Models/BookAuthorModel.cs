using System.ComponentModel.DataAnnotations;

namespace BookAuthors.Models
{
    public class BookAuthorModel
    {
        [Key]
        public int id{get;set;}
        [Required]
        public string fName{get;set;}
        [Required]
        public string lName{get;set;}
        public bool isActive{get;set;}
    }
}