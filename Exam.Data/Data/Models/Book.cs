﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Data.Data.Model
{
    public class Book
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }

        public int PagesCount { get; set; }

        public int PublishingYear { get; set; }
        public string PublicherName { get; set; }

        public decimal CostPrice { get; set; }
        public decimal Price { get; set; }

        public bool IsExtenshion { get; set; }

    }
}