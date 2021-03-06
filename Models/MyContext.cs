using Microsoft.EntityFrameworkCore;
 
namespace Stacks.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }
        public DbSet<Reader> Readers {get;set;}
        public DbSet<Book> Books {get;set;}
        public DbSet<Read> Reads {get;set;}
        public DbSet<ReadList> ReadLists {get;set;}
        public DbSet<Favorite> Favorites {get;set;}
        public DbSet<Comment> Comments {get;set;}
    }
}
