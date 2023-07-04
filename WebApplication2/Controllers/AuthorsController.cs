using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2Services.Authors;

namespace WebApplication2.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorRepository _service;
        public AuthorsController(IAuthorRepository service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult GetAuthors()
        {
            var authors = _service.GetAuthors();
            return Ok(authors);
        }
        [HttpGet("{id}")]
        public IActionResult GetAuthor(int id)
        {
            var author =_service.GetAuthor(id);
            if(author is null)
            {
                return NotFound();
            }
            return Ok(author);
        }
    }
}
