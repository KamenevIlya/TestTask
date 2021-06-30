using System.Collections.Generic;

namespace OrdersBL.Model
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Check> Checks { get; set; } //Связь 1 ко многим 

        public override string ToString()
        {
            return Name;
        }
    }
}