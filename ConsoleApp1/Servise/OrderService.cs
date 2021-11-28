using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Servise
{
    public class OrderService
    {
        public OrderService()
        {
            Order = new Order();
        }

        public Order Order { get; set; }
        public void OrderComplete()
        {
            Order.Guid = Guid.NewGuid();
        }
    }
}
