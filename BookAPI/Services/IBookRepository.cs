using System.Threading.Tasks;
using BookAPI.Models;

namespace BookAPI.Services
{
	public interface IBookRepository
	{
		Task<Book> GetAllBooks();
		Task<Book> GetBook(string isbn);
		Task CreateBook(Book book);
		Task UpdateBook(string isbn, Book book);
		Task Delete(string isbn);
	}
}