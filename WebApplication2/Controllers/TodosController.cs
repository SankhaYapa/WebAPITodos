using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private TodoService _todoService;

        public TodosController()
        {
            _todoService = new TodoService();
        }
        [HttpGet]
        public IActionResult GetTodos()  
        {
            var myTodos = _todoService.AllTodos();
            return Ok(myTodos);
        }
        [HttpGet("{id?}")]
        public IActionResult GetSpecificTodos(int? id)
        {

            var myTodos = _todoService.AllTodos().Where(t => t.Id == id);
            //   if(id is null) return Ok(myTodos);
            //   myTodos.Where(t => t.Id == id);
            return Ok(myTodos);
        }
    }
}
