using System.Threading.Tasks;
using BookAPI.Models;

namespace BookAPI.Services
{
	class BookRepository : IBookRepository
	{
		public Task<Book> GetAllBooks()
		{
			throw new System.NotImplementedException();
		}

		public Task<Book> GetBook(string isbn)
		{
			throw new System.NotImplementedException();
		}

		public Task CreateBook(Book book)
		{
			throw new System.NotImplementedException();
		}

		public Task UpdateBook(string isbn, Book book)
		{
			throw new System.NotImplementedException();
		}

		public Task Delete(string isbn)
		{
			throw new System.NotImplementedException();
		}
	}
}