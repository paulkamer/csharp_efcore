
using System;

namespace Domain.DTOs
{
    public class PostDto
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        public virtual AuthorDto Author { get; set; }
    }
}