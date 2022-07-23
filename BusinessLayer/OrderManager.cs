using DataAccessLayer;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class OrderManager
    {
        Repository<Order> orderRepo = new Repository<Order>();
        public int BLAdd(Order p)
        {
            if (p.OrderFee < 0 && p.CoffeeAmount < 0)
            {
                return -1;
            }
            return orderRepo.Insert(p);
        }
    }
}
