﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2Services.Models
{
    public class AuthorDto
    {
        public int Id { get; set; }
       
        public string FullName { get; set; }
    
        public string Address { get; set; }

    }
}