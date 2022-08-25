using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingDemo
{
    public class Product
    {
        public int Code { get; set; }
        public string Name { get; set; }
        private double price;
        public double Price
        {
            get { return price; }

            set 
            { if(value>0)
                {
                    price = value;
                }
                else
                {
                    throw new Exception("Please enter correct price");
                }
           
            }
        }
        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set 
            { 
                if (value>0 && value<100)
                {
                    quantity = value;
                }
            }
        }

        public Product(int code, string name, double price, int quantity)
        {
            Code = code;
            Name = name;
            this.Price = price;
            Quantity = quantity;
        }
    }
}
