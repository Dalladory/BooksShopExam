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
            using (AppDbContext context = new AppDbContext())
            {
                context.Books.Add(book);
                context.SaveChanges();
            }
        }

        public void Delete(Book book)
        {
            using (AppDbContext context = new AppDbContext())
            {
                context.Books.Remove(book);
                context.SaveChanges();
            }
        }

        public Book Get(string name)
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.Books.FirstOrDefault(b => b.Name == name);
            }
        }

        public IEnumerable<Book> GetAll()
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.Books.ToList();
            }
        }

        public void Update(Book book)
        {
            using (AppDbContext context = new AppDbContext())
            {
                context.Books.Update(book);
                context.SaveChanges();
            }
        }
    }
}
