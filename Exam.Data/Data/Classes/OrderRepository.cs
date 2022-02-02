using Exam.Data.Data.Interfaces;
using Exam.Data.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Data.Data.Classes
{
    public class OrderRepository : IOrderRepository
    {
        public void Add(Order order)
        {
            throw new NotImplementedException();
        }

        public void Delete(Order order)
        {
            throw new NotImplementedException();
        }

        public Order Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
