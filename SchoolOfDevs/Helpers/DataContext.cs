using Microsoft.EntityFrameworkCore;
using SchoolOfDevs.Entities;

namespace SchoolOfDevs.Helpers
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<User>User {get;set;}
        public DbSet<Note>Note {get;set;}
        public DbSet<Course>Courses {get;set;}
         
    }
}


