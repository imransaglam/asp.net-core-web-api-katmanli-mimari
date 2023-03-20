using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBookService.Contracts
{
    public interface IBookService
    {
        IEnumerable<Book> GetAllBooks(bool trackChanges);
        Book GetOneBookById(int id,bool trackChanges);
        Book CreateOneBook(Book book);
        void UpdateOneBook(int id,Book book,bool TrackChanges);
        void DeleteOneBook(int id,bool TrackChanges);
    }
}
