using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManage.Strategy;

namespace OrderManage.Models
{
    public class ElectricProduct : Product
    {
        public ElectricProduct(Guid id, string name, decimal price, IDiscountStrategy discountStrategy)
            : base(id, name, price, discountStrategy)
        {

        }

        public override void ShowInfo()
        {
            Console.WriteLine("Electric product");
        }
    }
}
