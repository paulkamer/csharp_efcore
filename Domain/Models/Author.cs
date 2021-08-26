using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public string Avatar { get; set; }

        public List<Post> Posts { get; set; }
    }
}