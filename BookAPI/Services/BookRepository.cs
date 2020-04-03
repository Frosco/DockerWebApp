using System.Collections.Generic;
using System.Threading.Tasks;
using BookAPI.Models;
using MongoDB.Driver;

namespace BookAPI.Services
{
	public class BookRepository : IBookRepository
	{
		private readonly IMongoCollection<Book> _books;

		public BookRepository(IBookstoreDatabaseSettings settings)
		{
			var client = new MongoClient(settings.ConnectionString);
			var database = client.GetDatabase(settings.DatabaseName);

			_books = database.GetCollection<Book>(settings.BooksCollectionName);

			PopulateDatabase();
		}

		public List<Book> GetAllBooks()
		{
			return _books.Find(book => true).ToList();
		}

		public Task<Book> GetBook(string id)
		{
			throw new System.NotImplementedException();
		}

		public Task CreateBook(Book book)
		{
			throw new System.NotImplementedException();
		}

		public Task UpdateBook(string id, Book book)
		{
			throw new System.NotImplementedException();
		}

		public Task Delete(string id)
		{
			throw new System.NotImplementedException();
		}

		private void PopulateDatabase()
		{
			var newBooks = new List<Book>
			{
				new Book
				{
					Author = "Astrid Lindgren",
					Publisher = "Rabén Sjögren",
					Title = "Här kommer Pippi Långstrump"
				},
				new Book
				{
					Author = "Michael Ende",
					Title = "Die unendliche Geschichte",
					Publisher = "K. Thienemanns Verlag"
				},
				new Book
				{
					Author = "Thorbjørn Egner",
					Title = "Folk og røvere i Kardemomme by",
					Publisher = "Cappelen"
				}
			};

			foreach (var book in newBooks)
			{
				_books.InsertOne(book);
			}
		}
	}
}