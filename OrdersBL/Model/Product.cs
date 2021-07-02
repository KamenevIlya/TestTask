using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersBL.Model
{
    public class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Count { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Price}";
        }


    }
}
