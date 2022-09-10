using LibraryService.Models;
using System.Collections.Generic;

namespace LibraryService.Services
{
    public interface ILibraryRepositoryService : IRepository<Book, string>
    {
        IList<Book> GetByTitle(string title);

        IList<Book> GetByAuthor(string authorName);

        IList<Book> GetByCategory(string category);
    }
}
