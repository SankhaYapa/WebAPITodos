using WebApplication2.Models;

namespace WebApplication2Services.Todos
{
    public class TodoService : ITodoRepository
    {
        public Todo AddTodo(int authorId, Todo todo)
        {
            throw new NotImplementedException();
        }

        //Get Todos
        public List<Todo> AllTodos(int authorId)
        {
            var todos = new List<Todo>();
            var todo1 = new Todo
            {
                Id = 1,
                Title = "Get books for school",
                Description = "Get some text books for school",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now.AddDays(5),
                Status = TodoStatus.New

            };
            todos.Add(todo1);
            var todo2 = new Todo
            {
                Id = 2,
                Title = "Get books for school",
                Description = "Get some text books for school",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now.AddDays(5),
                Status = TodoStatus.New

            };
            todos.Add(todo2);
            var todo3 = new Todo
            {
                Id = 3,
                Title = "Get books for school",
                Description = "Get some text books for school",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now.AddDays(5),
                Status = TodoStatus.New

            };
            todos.Add(todo3);
            var todo4 = new Todo
            {
                Id = 4,
                Title = "Get books for school",
                Description = "Get some text books for school",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now.AddDays(5),
                Status = TodoStatus.New

            };
            todos.Add(todo4);
            return todos;
        }

        public Todo GetTodo(int authorId, int id)
        {
            throw new NotImplementedException();
        }
    }
}
