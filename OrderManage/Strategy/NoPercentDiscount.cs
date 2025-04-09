using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManage.Strategy
{
    public class NoPercentDiscount: IDiscountStrategy
    {
        
        public decimal GetDiscount(decimal totalPrice)
        {
            return totalPrice - (totalPrice * 0.1m);
        } 
    }
}
