using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using WebApplication2Services.Models;
using WebApplication2Services.Todos;

namespace WebApplication2.Controllers
{
    [Route("api/authors/{authorId}/todos")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        
        private ITodoRepository _todoService;
        private IMapper _mapper;

        public TodosController(ITodoRepository repository,IMapper mapper )
        {
            _todoService = repository;
            _mapper = mapper;
        }
        //private TodoService _todoService; 

        //public TodosController()
        //{
        //    _todoService = new TodoService();
        //}
        [HttpGet]
        public ActionResult<ICollection<TodoDto>> GetTodos(int authorId)  
        {
            var myTodos = _todoService.AllTodos(authorId);
            var mapperTodos = _mapper.Map<ICollection<TodoDto>>(myTodos);
            return Ok(mapperTodos);
        }
        [HttpGet("{id}",Name ="GetTodo")]
        public IActionResult GetTodo(int authorId, int id)
        {
            var todo = _todoService.GetTodo(authorId,id);
            if (todo == null)
            {
                return NotFound();
            }
            var mapperTodo = _mapper.Map<TodoDto>(todo);
            return Ok(mapperTodo);
        }
        [HttpPost]
        public ActionResult<TodoDto> CreateTodo(int authorId, CreateTodoDto todo)
        {
            var todoEntity=_mapper.Map<Todo>(todo);
            var newTodo = _todoService.AddTodo(authorId, todoEntity);
            var todoForReturn=_mapper.Map<TodoDto>(newTodo);

            return CreatedAtRoute("GetTodo", new {authorId=authorId,id=todoForReturn.Id},todoForReturn);
        }
        [HttpPut("{todoId}")]
        public ActionResult UpdateTodo(int authorId, int todoId,UpdateTodoDto todo) {
            var updatingTodo=_todoService.GetTodo(authorId,todoId);
            if(updatingTodo == null)
            {
                return NotFound();
            }
            _mapper.Map(todo, updatingTodo);
            _todoService.UpdateTodo(updatingTodo);
            return NoContent();
        }
        [HttpDelete("{todoId}")]
        public ActionResult DeleteTodo(int authorId,int todoId) {
            var deletingTodo = _todoService.GetTodo(authorId, todoId);
            if (deletingTodo == null)
            {
                return NotFound();
            }
            _todoService.DeleteTodo(deletingTodo);
            return NoContent(); 
        }
    }
}
