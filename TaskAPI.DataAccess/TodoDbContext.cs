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
        public DbSet<Author> Author { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=DESKTOP-UKUD1D5;Database=TodoDB;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true";
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData( new Author[]
            {
                new Author { Id = 1,FullName="Sankha",AddressNo="45",Street="Street1",City="City 1",JobRole="Developer"},
                new Author { Id = 2,FullName="Yapa",AddressNo="46",Street="Street1",City="City 1",JobRole="Engineer"},
                new Author { Id = 3,FullName="Priyamantha",AddressNo="47",Street="Street1",City="City 1",JobRole="Developer"},
                new Author { Id = 4,FullName="Bandara",AddressNo="48",Street="Street1",City="City 1", JobRole = "QA"},
            });
            modelBuilder.Entity<Todo>().HasData(new Todo[] {
                new Todo{
                Id = 1,
                Title = "Get books for school form DB",
                Description = "Get some text books for school",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now.AddDays(5),
                Status = TodoStatus.New,
                AuthorId= 1,

            },new Todo{
                Id = 2,
                Title = "Get books for school form DB",
                Description = "Get some text books for school",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now.AddDays(5),
                Status = TodoStatus.New,
                AuthorId= 1,
            },new Todo{
                Id = 3,
                Title = "Get books for school form DB",
                Description = "Get some text books for school",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now.AddDays(5),
                Status = TodoStatus.New,
                AuthorId=3
            },new Todo{
                Id = 4,
                Title = "Get books for school form DB",
                Description = "Get some text books for school",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now.AddDays(5),
                Status = TodoStatus.New,
                AuthorId=4
            }}
            );
        }
    }
}
