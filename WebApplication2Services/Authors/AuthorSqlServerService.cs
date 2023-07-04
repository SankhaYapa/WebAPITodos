using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.DataAccess;
using WebApplication2.Models;

namespace WebApplication2Services.Authors
{
   
    public class AuthorSqlServerService : IAuthorRepository
    {
        private readonly TodoDbContext _context=new TodoDbContext();
        public List<Author> GetAuthors()
        {
            return _context.Author.ToList();
        }
        public Author GetAuthor(int id)
        {
            return _context.Author.Find(id);
        }

       
    }
}
