using FolwerlandDB.Entities.Product;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolwerLandBase {
	class FlowerLandContext : DbContext {
		public FlowerLandContext()
			: base("name=FlowerLandDB") {
			Database.SetInitializer<FlowerLandContext>(new DropCreateDatabaseIfModelChanges<FlowerLandContext>());
		}

		public DbSet<Category> Categories { get; set; }
		public DbSet<Employee> Employees { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Order> Order { get; set; }
		public DbSet<Cart> Carts { get; set; }
	}
}
