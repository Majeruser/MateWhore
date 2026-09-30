using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recordlinq
{
    internal record Hotel(string Name, string City ,int Stars)
    {
        private int _stars { get; init; } = Stars;
        private int _pricePerNigth { get; set;  }
        public double Ratimg { get; set; }
        public bool Is4star()
        {
            return _stars >= 4;
        }
        public void setPriceNigth(int price)
        {
            _pricePerNigth = price;
        }
        public int AllHotelnigths(int hotelnigths) { 
            return _pricePerNigth * hotelnigths;
        }
    }
}
