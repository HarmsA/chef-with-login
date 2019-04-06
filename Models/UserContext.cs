using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace newlogin.Models
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions options) : base(options){}
        public DbSet<User> Users {get;set;}
        public DbSet<Post> Posts {get;set;}
    }
}