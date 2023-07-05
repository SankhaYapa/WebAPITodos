﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2Services.Authors
{
    public interface IAuthorRepository
    {
        public List<Author> GetAuthors();
        public List<Author> GetAuthors(string job,string search);
        public Author GetAuthor(int id);
        public Author AddAuthor(Author author);
    }
}
