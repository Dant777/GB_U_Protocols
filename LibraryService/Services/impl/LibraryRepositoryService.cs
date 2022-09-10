using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using LibraryService.Models;

namespace LibraryService.Services.impl
{
    public class LibraryRepositoryService : ILibraryRepositoryService
    {

        private readonly ILibraryDatabaseContextService _db;

        public LibraryRepositoryService(ILibraryDatabaseContextService db)
        {
            _db = db;
        }
        public IList<Book> GetByTitle(string title)
        {
            try
            {
                return _db.Books
                    .Where(b => b.Title.ToLower().Contains(title.ToLower())).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error - {e.Message}");
                return new List<Book>();
            }
            
        }

        public IList<Book> GetByAuthor(string authorName)
        {
            return _db.Books.Where(book =>
                book.Authors.Where(author =>
                    author.Name.ToLower().Contains(authorName.ToLower())).Count() > 0).ToList();
        }

        public IList<Book> GetByCategory(string category)
        {
            try
            {
                return _db.Books
                    .Where(b => b.Category.ToLower().Contains(category.ToLower())).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error - {e.Message}");
                return new List<Book>();
            }
        }

        public string Add(Book item)
        {
            throw new System.NotImplementedException();
        }

        public int Update(Book item)
        {
            throw new System.NotImplementedException();
        }

        public int Delete(Book item)
        {
            throw new System.NotImplementedException();
        }

        public IList<Book> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Book GetById(string id)
        {
            throw new System.NotImplementedException();
        }


    }
}