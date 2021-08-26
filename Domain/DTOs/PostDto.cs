
using System;

namespace Domain.DTOs
{
    public class PostDto
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        public AuthorDto Author { get; set; }
    }
}