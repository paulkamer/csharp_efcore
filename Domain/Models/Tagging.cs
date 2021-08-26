using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class Tagging
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Tag Tag { get; set; }
        [Required]
        public Post Post { get; set; }
    }
}