﻿using Exam.Data.Data.Model;
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

    }
}
