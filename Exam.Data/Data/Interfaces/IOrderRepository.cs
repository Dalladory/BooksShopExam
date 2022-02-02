using Exam.Data.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Data.Data.Interfaces
{
    public interface IOrderRepository
    {
        void Add(Order order);

        Order Get(int id);

        IEnumerable<Order> GetAll();

        void Update(Order order);
        void Delete(Order order);
    }
}
