// See https://aka.ms/new-console-template for more information

using OrderManage.Models;
using OrderManage.Strategy;

IDiscountStrategy discountStrategy = new PercentDiscount(10);
FoodProduct product = new FoodProduct(Guid.NewGuid(), "Food 1", 1000, discountStrategy);
product.ShowInfo();
Console.WriteLine(product.Name);
Console.ReadLine(); // hoặc Console.ReadKey();