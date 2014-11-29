using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerlandDB {
	class FlowerlandDBContext : DbContext {
		public FlowerlandDBContext()
			: base("name=FlowerLandDB") {
			Database.SetInitializer<FlowerlandDBContext>(new DropCreateDatabaseIfModelChanges<FlowerlandDBContext>());
		}

		public DbSet<Category> Categories { get; set; }
		public DbSet<Employee> Employees { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Order> Order { get; set; }
		public DbSet<Cart> Carts { get; set; }

        // დღევანდელი
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductProperty> ProductProperties { get; set; }
        public DbSet<ProductTemplate> ProductTemplates { get; set; }
        public DbSet<ProductValue> ProductValues { get; set; }
        public DbSet<Property> Properties { get; set; }
    }
}
