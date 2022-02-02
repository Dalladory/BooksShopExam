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
            using (AppDbContext context = new AppDbContext())
            {
                context.Orders.Add(order);
                context.SaveChanges();
            }
        }

        public void Delete(Order order)
        {
            using (AppDbContext context = new AppDbContext())
            {
                context.Orders.Remove(order);
                context.SaveChanges();
            }
        }

        public Order Get(int id)
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.Orders.Find(id);
            }
        }

        public IEnumerable<Order> GetAll()
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.Orders.ToList();
            }
        }

        public void Update(Order order)
        {
            using (AppDbContext context = new AppDbContext())
            {
                context.Orders.Update(order);
                context.SaveChanges();
            }
        }
    }
}
