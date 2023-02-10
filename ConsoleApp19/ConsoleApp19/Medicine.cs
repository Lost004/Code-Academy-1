﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp19
{
    class Medicine
    {
        private string _name;
        private double _price;
        private double _discountPrice;
        public string Category;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length <= 3 && char.IsUpper(value[0]))
                    _name = value;
                
            }
        }
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value >= 0)
                    _price = value;
            }
        }
        public double DiscountPrice
        {
            get
            {
                return _discountPrice;
            }
            set
            {
                if (value >= 0)
                {
                    value = (Price * value) / 100;
                    _discountPrice = value;
                }



            }
        }

    }
}