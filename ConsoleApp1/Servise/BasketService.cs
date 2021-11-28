using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Model;

namespace ConsoleApp1.Servise
{
    public class BasketService
    {
        public Basket Basket
        {
            get
            {
                return Basket.BasketValue;
            }
        }

        public void AddProduct(Product product)
        {
            for (int i = 0; i < Basket.Products.Length; i++)
            {
                if (Basket.Products[i] == null)
                {
                    Basket.Products[i] = product;
                    break;
                }
            }
        }
    }
}
