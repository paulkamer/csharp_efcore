using System;
using System.Collections.Generic;

namespace Domain.DTOs
{
    public class AuthorDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Avatar { get; set; }

        public List<PostDto> Posts { get; set; }
    }
}