using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManage.Strategy;

namespace OrderManage.Models
{
    public class FoodProduct : Product
    {
        public DateTime Exprire;
        public FoodProduct(Guid id, string name, decimal price, IDiscountStrategy discountStrategy, DateTime exprire)
            : base(id, name, price, discountStrategy)
        {
            Exprire= exprire;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"[Thực phẩm] ID={Id} | Tên: {Name} | Gía: {Price} | Gía sau giảm: {GetPriceAfterDiscount()}");
        }
    }
}
