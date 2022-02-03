using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Data.Data.Model
{
    public class Order
    {
        public int Id { get; set; }

        public decimal Price { get; set; }
        public int BookId { get; set; }

        public Book Book { get; set; }

        public DateTime Date { get; set; }

    }
}
