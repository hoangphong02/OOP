using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManage.Strategy;

namespace OrderManage.Models
{
    public abstract class Product
    {
        public Guid Id { get; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public IDiscountStrategy DiscountStrategy { get; set; }


        protected Product(Guid id, string name, decimal price , IDiscountStrategy discountStrategy)
        {
            Id = id;
            Name = name;
            Price = price;
            DiscountStrategy = discountStrategy;
        }

        public decimal GetPriceAfterDiscount() { return DiscountStrategy.GetDiscount(Price); } 
        public abstract void ShowInfo();
        //public virtual void ShowInfo()
        //{
        //    Console.WriteLine($"ID: {Id}, Name: {Name}");
        //}

    }
}

//virtual                                                 abstract
//Có sẵn code logic bên trong	                            Không có code, chỉ định nghĩa
//Class con có quyền override hoặc không cũng được	        Class con bắt buộc phải override
//Class cha có thể tạo object bình thường	                Class cha phải là abstract class (không tạo object trực tiếp)
