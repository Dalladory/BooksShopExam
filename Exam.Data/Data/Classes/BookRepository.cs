using Exam.Data.Data.Interfaces;
using Exam.Data.Data.Model;
using Exam.Data.Data.Models;
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

        

        public void DeleteRange(IEnumerable<Book> books)
        {
            using (AppDbContext context = new AppDbContext())
            {
                context.Books.RemoveRange(books);
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

        public void AddGenre(Genre genre)
        {
            using (AppDbContext context = new AppDbContext())
            {
                context.Genres.Add(genre);
                context.SaveChanges();
            }
        }

        public IEnumerable<Genre> GetAllGenres()
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.Genres.ToList();
            }
        }

        public void DeleteGenre(Genre genre)
        {
            using (AppDbContext context = new AppDbContext())
            {
                context.Genres.Remove(genre);
                context.SaveChanges();
            }
        }

        
    }
}
