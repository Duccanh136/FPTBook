using System;
using System.ComponentModel.DataAnnotations;

namespace FPTBook.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [MaxLength(13)]
        public string ISBN { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date Published")]
        public DateTime DatePublished { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public int Price { get; set; }
        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; }
    }
}
