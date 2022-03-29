using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork_2
{
    class Product
    {
        public Product(string name)
        {
            Name = name;
        }
        private string _name;
        public int Count;
        public double Price;
        public double TotalInCome;

        public string Name { 
            get 
            {
                return _name;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _name = value;
                }
            }
        }

        public void Sell()
        {
            if (Count > 0)
            {
                Count--;
                TotalInCome += Price;
            }
            else
            {
                Console.WriteLine("mehsul bitib");
            }
        }
    }
}
