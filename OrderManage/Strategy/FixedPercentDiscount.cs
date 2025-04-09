using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManage.Strategy
{
    public class FixedPercentDiscount: IDiscountStrategy
    {
        private readonly decimal _percent;
        public FixedPercentDiscount(decimal percent)
        {
            _percent = percent;
        }
        public decimal GetDiscount(decimal totalPrice)
        {
            return totalPrice - (totalPrice * _percent / 100);
        } 
    }
}
