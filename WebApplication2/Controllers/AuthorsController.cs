using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using WebApplication2Services.Authors;
using WebApplication2Services.Models;

namespace WebApplication2.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorRepository _service;
        private readonly IMapper _mapper;
        public AuthorsController(IAuthorRepository service,IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        //[HttpGet]
        //public IActionResult GetAuthors()
        //{
        //    var authors = _service.GetAuthors();
        //    return Ok(authors);
        //}
        //[HttpGet("{id}")]
        //public IActionResult GetAuthor(int id)
        //{
        //    var author =_service.GetAuthor(id);
        //    if(author is null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(author);
        //}

        //mapping data 
        [HttpGet]
        public ActionResult<ICollection<AuthorDto>> GetAuthors(string? job,string? search)
        {
          //  throw new Exception("Test Error");
            var authors = _service.GetAuthors(job,search);
           // var authorsDto = new List<AuthorDto>();
            //foreach (var author in authors)
            //{
            //    authorsDto.Add(new AuthorDto
            //    {
            //        Id = author.Id,
            //        FullName = author.FullName,
            //        Address = $"{author.AddressNo},{author.Street},{author.City}"
            //    });
            //}
           var mapAuthors= _mapper.Map<ICollection<AuthorDto>>(authors);
            return Ok(mapAuthors);
        }
        [HttpGet("{id}", Name = "GetAuthor")]
        public IActionResult GetAuthor(int id)
        {
            var author = _service.GetAuthor(id);
            if (author is null)
            {
                return NotFound();
            }
            var mappedAuthor=_mapper.Map<AuthorDto>(author);
            return Ok(mappedAuthor);
        }
        [HttpPost]
        public ActionResult<AuthorDto> CreateAuthor(CreateAuthorDto author) {
           
            var authorEntity=_mapper.Map<Author>(author);
            var newAuthor=_service.AddAuthor(authorEntity);

            var authorForReturn=_mapper.Map<AuthorDto>(newAuthor);

            return CreatedAtRoute("GetAuthor", new {id=authorForReturn.Id},authorForReturn);
        }

    }
}
 