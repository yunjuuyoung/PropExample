﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropExample
{
    class Product
    {
        public string name;
        public int price;

        public Product()
        {
        }

        public Product (string name, int price)
        {
            this.name = name;
            this.price = price;
        }
    }
}
