using Microsoft.EntityFrameworkCore;
using SchoolOfDevs.Entities;

namespace SchoolOfDevs.Helpers
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<User>Users {get;set;}
        public DbSet<Note>Notes {get;set;}
        public DbSet<Course>Courses {get;set;}
         
    }
}
 

