using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManage.Models
{
    public class FoodProduct : Product
    {   
        public FoodProduct(Guid id, string name, decimal price)
            :base(id, name,price)
        {
          
        }

        public override void showInfo()
        {
            throw new NotImplementedException();
        }
    }
}
