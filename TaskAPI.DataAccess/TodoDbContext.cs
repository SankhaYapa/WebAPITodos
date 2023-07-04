using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace TaskAPI.DataAccess
{
    public class TodoDbContext:DbContext
    {
        public DbSet<Todo>Todos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=DESKTOP-UKUD1D5;Database=TodoDB;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true";
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>().HasData(new Todo
            {
                Id = 1,
                Title = "Get books for school form DB",
                Description = "Get some text books for school",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now.AddDays(5),
                Status = TodoStatus.New

            });
        }
    }
}
