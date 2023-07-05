using Microsoft.AspNetCore.Mvc;
using Repository_Pattern_With_UOW.Core;
using Repository_Pattern_With_UOW.Core.Interfaces;
using Repository_Pattern_With_UOW.Core.Models;
using Repository_Pattern_With_UOW.EF;

namespace Repository_Pattern_With_UOW.Api.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class AuthorsController : Controller
    {

        private readonly IUnitOfWork _unitOfWork;
        public AuthorsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]

        public IActionResult GetById()
        {
            return Ok(_unitOfWork.Authors.GetById(1));
        }
        [HttpGet("GetByIdAsync")]
        public async Task<IActionResult> GetByIdAsync()
        {
            return Ok(await _unitOfWork.Authors.GetByIdAsync(1));
        }
   
        }
    }

