using Exam.Data.Data.Interfaces;
using Exam.Data.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Service
{
    public class OrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void Add(Order order)
        {
            if (order is not null)
            {
                _orderRepository.Add(order);
            }
            else
            {
                throw new NullReferenceException("Order is null");
            }
        }

        public void Delete(Order order)
        {
            if (order is not null)
            {
                _orderRepository.Delete(order);
            }
            else
            {
                throw new NullReferenceException("Order is null");
            }
        }

        public Order Get(int id)
        {
            Order order = _orderRepository.Get(id);

            if (order is not null)
            {
                return order;
            }

            throw new KeyNotFoundException("Order is not found");
        }

        public IEnumerable<Order> GetAll()
        {
            return _orderRepository.GetAll();
        }

        public void Update(Order order)
        {
            if (order is not null)
            {
                _orderRepository.Update(order);
            }
            else
            {
                throw new NullReferenceException("Order is null");
            }
        }



    }
}
