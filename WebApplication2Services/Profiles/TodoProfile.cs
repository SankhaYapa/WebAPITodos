using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication2.Models;
using WebApplication2Services.Models;

namespace WebApplication2Services.Profiles
{
    public class TodoProfile:Profile
    {
        public TodoProfile()
        {
            CreateMap<Todo, TodoDto>();
            CreateMap<CreateTodoDto, Todo>();
        }
    }
}
