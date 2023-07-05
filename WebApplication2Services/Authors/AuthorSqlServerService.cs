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
        public List<Author> GetAuthors(string job,string search)
        {
            if (string.IsNullOrWhiteSpace(job)&&string.IsNullOrWhiteSpace(search))
            {
                return _context.Author.ToList();
            }
            var authorCollection=_context.Author as IQueryable<Author>;
            if (!string.IsNullOrWhiteSpace(job))
            {
                job = job.Trim();
                authorCollection=authorCollection.Where(a=>a.JobRole == job);
              }
            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.Trim();
                authorCollection=authorCollection.Where(a=>a.FullName.Contains(search)||a.City.Contains(search));
            }
            return authorCollection.ToList();

        }

        public Author GetAuthor(int id)
        {
            return _context.Author.Find(id);
        }
        public Author AddAuthor(Author author)
        {

                _context.Author.Add(author);
                _context.SaveChanges();

            return _context.Author.Find(author.Id);
        }
       
    }
}
