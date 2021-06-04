using System.Data.Entity;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfContext : DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<SubscribeMail> SubscribeMails { get; set; }
    }
}
