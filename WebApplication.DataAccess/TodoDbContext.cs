using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskAPIDataAccess
{
    public class TodoDbContext:DbContext
    {
        public DbSet<TodoDbContext>Todos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=DESKTOP-UKUD1D5;Database=TodoDB;Trusted_Connection=True;MultipleActiveResultSets=true;";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
