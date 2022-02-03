using Exam.Data.Data.Model;
using Exam.Data.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Data.Data.Interfaces
{
    public interface IBookRepository
    {
        void Add(Book book);

        Book Get(string name);

        IEnumerable<Book> GetAll();

        void Update(Book book);
        void Delete(Book book);

        void DeleteRange(IEnumerable<Book> books);

        void AddGenre(Genre genre);
        IEnumerable<Genre> GetAllGenres();
        void DeleteGenre(Genre genre);


    }
}
