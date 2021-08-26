
using System;

namespace Domain.DTOs
{
    public class TaggingDto
    {
        public int Id { get; set; }
        public TagDto Tag { get; set; }
        public PostDto Post { get; set; }
    }
}