using System.Data.Entity;

namespace OrdersBL.Model
{
    public class OrdersContext :DbContext
    {
        public OrdersContext() : base("CRMConnection") { }

        public DbSet<Check> Checks { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Sell> Sells { get; set; }

        public DbSet<Seller> Sellers { get; set; }
    }
}
