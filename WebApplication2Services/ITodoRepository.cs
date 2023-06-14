using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2Services
{
    public interface ITodoRepository
    {
        public List<Todo> AllTodos();
        
    }
}
