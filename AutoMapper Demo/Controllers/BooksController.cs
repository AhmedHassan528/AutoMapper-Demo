using AutoMapper;
using AutoMapper_Demo.Dtos;
using AutoMapper_Demo.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapper_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IMapper _mapper;

        public BooksController(IMapper mapper)
        {
            _mapper = mapper;
        }

        List<Book> books = new()
        {
            new Book { BookId = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Summary = "A novel about the American Dream", Price = 100.5 },
            new Book { BookId = 2, Title = "The Catcher in the Rye", Author = "J.D. Salinger", Summary = "A novel about teenage angst", Price = 75.0 },
            new Book { BookId = 3, Title = "To Kill a Mocking", Author = "Harper Lee", Summary = "A novel about racial injustice", Price = 0 }
        };

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_mapper.Map<List<BookDto>>(books));
        }
        [HttpGet("{id}")]
        public IActionResult Details(int id)
        {
            var book = books.SingleOrDefault(b => b.BookId == id);
            return Ok(_mapper.Map<BookDto>(book));
        }
        [HttpPost]
        public IActionResult Create(BookDto dto)
        {
            return Ok(_mapper.Map<Book>(dto));
        }

    }
}
