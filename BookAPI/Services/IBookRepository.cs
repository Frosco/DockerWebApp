﻿using System.Collections.Generic;
using System.Threading.Tasks;
using BookAPI.Models;

namespace BookAPI.Services
{
	public interface IBookRepository
	{
		List<Book> GetAllBooks();
		Task<Book> GetBook(string id);
		Task CreateBook(Book book);
		Task UpdateBook(string id, Book book);
		Task Delete(string id);
	}
}