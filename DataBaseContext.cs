using Microsoft.EntityFrameworkCore;
using entityframework.Models;

namespace entityframework
{
    /// Mapping EF with objects
    public class DataBaseContext : DbContext
    {
        public DbSet<Category>? Category { get; set; }
        public DbSet<entityframework.Models.Task>? Task { get; set; }

        /// base(option) is similar a call parent::TaskContext()
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }
    }
}