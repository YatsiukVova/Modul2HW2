using ConsoleApp1.Servise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
   public class Basket
    {
        private static readonly Basket _basketValue = new Basket();
        private readonly Product[] _products;
        private readonly ConfigService _configService;
        static Basket()
        {
        }

        private Basket()
        {
            _configService = new ConfigService();
            _products = new Product[_configService.BasketConfig.BasketLength];
        }

        public Product[] Products => _products;
        public static Basket BasketValue => _basketValue;
    }
}
