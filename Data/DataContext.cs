using dotnet.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet.Data
{
    // DBContext corresponds to database, DBSet to a table or view in db
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        // name of table in db Characters
        public DbSet<Character> Characters { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<Skill> Skills { get; set; }
    }
}