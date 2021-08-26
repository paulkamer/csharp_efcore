using System;
using Microsoft.EntityFrameworkCore;
using Domain.Models;

namespace DataAccess
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Author> Authors { get; set; }

        public DbSet<Tag> Tags { get; set; }
        public DbSet<Tagging> Taggings { get; set; }
    }
}
