using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public int CoffeeAmount { get; set; }
        public int OrderFee { get; set; }
    }
}
