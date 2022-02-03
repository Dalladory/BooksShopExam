using Exam.Data.Data;
using Exam.Data.Data.Interfaces;
using Exam.Data.Data.Model;
using Exam.Data.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Service
{
    public class BookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public void Add(Book book)
        {
            if(book is not null)
            {
                _bookRepository.Add(book);
            }
            else
            {
                throw new NullReferenceException("Book is null");
            }
        }

        public void Delete(Book book)
        {
            if (book is not null)
            {
                _bookRepository.Delete(book);
            }
            else
            {
                throw new NullReferenceException("Book is null");
            }
        }

        public void DeleteRange(IEnumerable<Book> books)
        {
            if (books is not null)
            {
                _bookRepository.DeleteRange(books);
            }
            else
            {
                throw new NullReferenceException("Book is null");
            }
        }

        public Book Get(string name)
        {
            Book book = _bookRepository.Get(name);

            if(book is not null)
            {
                return book;
            }

            throw new KeyNotFoundException("Book is not found");
        }

        public IEnumerable<Book> GetAll()
        {
            return _bookRepository.GetAll();
        }

        public void Update(Book book)
        {
            if (book is not null)
            {
                _bookRepository.Update(book);
            }
            else
            {
                throw new NullReferenceException("Book is null");
            }
        }

        public void AddGenre(Genre genre)
        {
            if (genre is not null)
            {
                _bookRepository.AddGenre(genre);
            }
            else
            {
                throw new NullReferenceException("Genre is null");
            }
        }

        public IEnumerable<Genre> GetAllGenres()
        {
            return _bookRepository.GetAllGenres();
        }
        public void DeleteGenre(Genre genre)
        {
            if (genre is not null)
            {
                _bookRepository.DeleteGenre(genre);
            }
            else
            {
                throw new NullReferenceException("Genre is null");
            }
        }

    }
}
