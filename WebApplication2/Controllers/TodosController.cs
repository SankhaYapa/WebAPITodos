using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using WebApplication2Services.Todos;

namespace WebApplication2.Controllers
{
    [Route("api/todos")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        
        private ITodoRepository _todoService;

        public TodosController(ITodoRepository repository )
        {
            _todoService = repository;
        }
        //private TodoService _todoService; 

        //public TodosController()
        //{
        //    _todoService = new TodoService();
        //}
        [HttpGet]
        public IActionResult GetTodos()  
        {
            var myTodos = _todoService.AllTodos();
            return Ok(myTodos);
        }
        [HttpGet("{id}")]
        public IActionResult GetTodo(int id)
        {
            var todo=_todoService.GetTodo(id);
            if(todo == null)
            {
                return NotFound();
            }
            return Ok(todo);
        }
    }
}
