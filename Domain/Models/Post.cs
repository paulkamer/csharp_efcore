using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        public string Body { get; set; }

        [Required]
        public Author Author { get; set; }
    }
}