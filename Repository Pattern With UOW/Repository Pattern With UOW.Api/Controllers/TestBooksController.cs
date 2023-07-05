using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository_Pattern_With_UOW.Core.Consts;
using Repository_Pattern_With_UOW.Core.Interfaces;
using Repository_Pattern_With_UOW.Core.Models;

namespace Repository_Pattern_With_UOW.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestBooksController : ControllerBase
    {
        private readonly IBaseRepository<Book> _booksRepository;
        public TestBooksController(IBaseRepository<Book> booksRepository)
        {
            _booksRepository = booksRepository;
        }
        [HttpGet]
        public IActionResult GetById()
        {
            return Ok(_booksRepository.GetById(1));
        }
      

       
        [HttpGet("GetByIdAsync")]
        public async Task<IActionResult> GetByIdAsync()
        {
            return Ok(await _booksRepository.GetByIdAsync(1));
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_booksRepository.GetAll());
        }
        [HttpGet("GetByName")]
        public IActionResult GetByName()
        {
            return Ok(_booksRepository.Find(b => b.Title == "Api", new[] { "Author" }));
        }
        [HttpGet("GetAllWithAuthors")]
        public IActionResult GetAllWithAuthors()
        {
            return Ok(_booksRepository.FindAll(b => b.Title.Contains ( "Api"), new[] { "Author" }));
        }
        [HttpGet("GetOrder")]
        public IActionResult GetOrder()
        {
            return Ok(_booksRepository.FindAll(b => b.Title.Contains("Api"),null, null,b=>b.Id, OrderBy.Descending  ));
        }
        [HttpPost("AddOne")]
        public IActionResult AddOne()
        {
            return Ok(_booksRepository.Add(new Book { Title = "MVC", AuthorId = 1 }));
        }

    }
}
