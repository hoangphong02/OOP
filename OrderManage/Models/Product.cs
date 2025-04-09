using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManage.Models
{
    public abstract class Product
    {
        public Guid Id { get; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        

        protected Product(Guid id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
        public abstract void showInfo();
    }
}
