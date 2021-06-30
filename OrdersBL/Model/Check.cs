using System;
using System.Collections.Generic;

namespace OrdersBL.Model
{
    public class Check
    {
        public int CheckId { get; set; }

        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }

        public int SellerId { get; set; }

        public virtual Seller Seller { get; set; }

        public DateTime Created { get; set; }

        public ICollection<Sell> Sells { get; set; }

        public decimal Amount { get; set; }

        public override string ToString()
        {
            return $"№{CheckId} от {Created.ToString("dd.MM.yy hh:mm:ss")}";
        }
    }
}