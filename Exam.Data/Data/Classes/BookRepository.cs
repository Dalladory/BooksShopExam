using Exam.Data.Data.Interfaces;
using Exam.Data.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Data.Data.Classes
{
    public class BookRepository : IBookRepository
    {
        public void Add(Book book)
        {
            throw new NotImplementedException();
        }

        public void Delete(Book book)
        {
            throw new NotImplementedException();
        }

        public Book Get(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
