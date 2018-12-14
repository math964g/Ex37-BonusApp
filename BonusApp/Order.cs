using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusApp
{
    public class Order
    {
        public BonusProvider Bonus {get; set;}
        public List<Product> products = new List<Product>();

        public void AddProduct(Product productItem)
        {
            products.Add(productItem);
        }

        public double GetValueOfProducts()
        {
            return products.Sum(item => item.Value);
        }

        public double GetBonus()
        {
            return Bonus(GetValueOfProducts());
        }

        public double GetTotalPrice()
        {
            return GetValueOfProducts() - GetBonus();
        }
    }
}
