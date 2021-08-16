using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Domain.Models;
using Domain.DTOs;

namespace DataAccess.Services
{
  public class BlogService
  {
    private readonly BlogContext _context;

    public BlogService(BlogContext context)
    {
        _context = context;
    }

    public async Task<List<PostDto>> GetAllPosts()
    {
      List<PostDto> posts = await (
          from p in _context.Posts.AsNoTracking()
          orderby p.CreatedAt descending
          select new PostDto
          {
              Id = p.Id,
              Title = p.Title,
              CreatedAt = p.CreatedAt,
              Author = new AuthorDto {
                Id = p.Author.Id,
                Name = p.Author.Name
              }
          })
          .ToListAsync();

      return posts;
    }

    public async Task<List<AuthorDto>> GetAllAuthors()
    {
        List<AuthorDto> authors = await (
          from a in _context.Authors.AsNoTracking()
          select new AuthorDto
          {
              Id = a.Id,
              Name = a.Name,
              Avatar = a.Avatar,
          })
          .ToListAsync();

      return authors;
    }
  }
}