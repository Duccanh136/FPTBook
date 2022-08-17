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
        public DateTime DatePublished { get; set; } = DateTime.Now;
        [Required]
        public double Price { get; set; }
        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; }
    }
}
