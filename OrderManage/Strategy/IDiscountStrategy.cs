using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManage.Strategy
{
    public interface IDiscountStrategy
    {
        decimal getDiscount(decimal totalPrice);
    }
}
