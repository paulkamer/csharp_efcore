using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DataAccess.Services;
using Domain.DTOs;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlogController : ControllerBase
    {
        private readonly BlogService _blogService;
        private readonly ILogger<BlogController> _logger;

        public BlogController(BlogService blogService, ILogger<BlogController> logger)
        {
            _blogService = blogService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<PostDto>> GetPosts()
        {
            return await _blogService.GetAllPosts();
        }

        [HttpGet]
        [Route("authors")]
        public async Task<IEnumerable<AuthorDto>> GetAuthors()
        {
            return await _blogService.GetAllAuthors();
        }
    }
}
