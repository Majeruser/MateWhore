using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recordlinq
{
    internal record SmartPhone(string brand, string model, int releasYear)
    {
        private int _releasYear { get; init; } = releasYear;
        private int _price { get; set; }
        public double Rating { get; set; }

        public void SetPrice(int newPrice)
        {
            _price = newPrice;
        }
        public void UpdatePrice(int percent)
        {
            _price = _price*(percent/100);
        }
        public int getYaar()
        {
            return releasYear;
        }

    }
}
