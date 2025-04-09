using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManage.Strategy
{
    public class PercentDiscount: IDiscountStrategy
    {
        private readonly decimal _percent;
        public PercentDiscount(decimal percent)
        {
            _percent = percent;
        }
        public decimal getDiscount(decimal totalPrice)
        {
            return totalPrice - (totalPrice * _percent / 100);
        } 
    }
}
