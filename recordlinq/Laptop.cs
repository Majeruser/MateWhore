using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recordlinq
{
    public record Laptop(string brand, string model, string processor)
    {
        private int _price { get; set; }
        private string _processor { get; set; } = processor;
        public int Memory { get; set; }


        public int GetP()
        {
            return _price;
        }
        public string Proc()
        {
            return processor;
        }

        public void L(int price)
        {
            _price += price;
        }
        public void Mem(int memory)
        {
            Memory = Memory + memory;
        }
    }
}