using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository_Pattern_With_UOW.Core;
using Repository_Pattern_With_UOW.Core.Consts;
using Repository_Pattern_With_UOW.Core.Interfaces;
using Repository_Pattern_With_UOW.Core.Models;
using Repository_Pattern_With_UOW.EF;

namespace Repository_Pattern_With_UOW.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BooksController(IUnitOfWork unitOfWork)
        {
            _unitOfWork= unitOfWork;
    }
        [HttpGet]
        public IActionResult GetById()
        {
            return Ok(_unitOfWork.Books.GetById(1));
        }



        [HttpGet("GetByIdAsync")]
        public async Task<IActionResult> GetByIdAsync()
        {
            return Ok(await _unitOfWork.Books.GetByIdAsync(1));
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_unitOfWork.Books.GetAll());
        }
        [HttpGet("GetByName")]
        public IActionResult GetByName()
        {
            return Ok(_unitOfWork.Books.Find(b => b.Title == "Api", new[] { "Author" }));
        }
        [HttpGet("GetAllWithAuthors")]
        public IActionResult GetAllWithAuthors()
        {
            return Ok(_unitOfWork.Books.FindAll(b => b.Title.Contains("Api"), new[] { "Author" }));
        }
        [HttpGet("GetOrder")]
        public IActionResult GetOrder()
        {
            return Ok(_unitOfWork.Books.FindAll(b => b.Title.Contains("Api"), null, null, b => b.Id, OrderBy.Descending));
        }
        [HttpPost("AddOne")]
        public IActionResult AddOne()
        {
            var book= _unitOfWork.Books.Add(new Book { Title = "MVC", AuthorId = 1 });
            _unitOfWork.Complete();
            return Ok();
        }

    }
}

