using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Configs;
using ConsoleApp1.Model;

namespace ConsoleApp1.Servise
{
    public class ConfigService
    {
        private readonly Config _config;
        public ConfigService()
        {
            _config = new Config() { BasketConfig = new BasketConfig(), CurrencyConfig = new CurrencyConfig() };
            BasketConfig.BasketLength = 10;
            CurrencyConfig.UsdTransfer = 21;
        }

        public BasketConfig BasketConfig
        {
            get
            {
                return _config.BasketConfig;
            }
        }

        public CurrencyConfig CurrencyConfig
        {
            get
            {
                return _config.CurrencyConfig;
            }
        }
    }
}
