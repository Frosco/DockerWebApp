using System.Collections.Generic;
using System.Threading.Tasks;
using BookAPI.Models;
using BookAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BookController : ControllerBase
	{
		private readonly IBookRepository _bookRepository;

		public BookController(IBookRepository bookRepository)
		{
			_bookRepository = bookRepository;
		}

		// GET: api/Book
		[HttpGet]
		public ActionResult<IEnumerable<Book>> Get()
		{
			var books = _bookRepository.GetAllBooks();
			
			return Ok(books);
		}

		// GET: api/Book/5
		[HttpGet("{id}", Name = "Get")]
		public async Task<ActionResult<Book>> Get(string id)
		{
			return Ok(await _bookRepository.GetBook(id));
		}

		// POST: api/Book
		[HttpPost]
		public async Task<IActionResult> Post([FromBody] Book book)
		{
			await _bookRepository.CreateBook(book);
			return NoContent();
		}

		// PUT: api/Book/5
		[HttpPut("{id}")]
		public async Task<IActionResult> Put(string id, [FromBody] Book book)
		{
			await _bookRepository.UpdateBook(id, book);
			return NoContent();
		}

		// DELETE: api/ApiWithActions/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> Delete(string id)
		{
			await _bookRepository.Delete(id);
			return NoContent();
		}
	}
}