using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Challenge1
{
    public class BlogContext : DbContext
    {
        public BlogContext()
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
            

        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //}



        //entities
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}