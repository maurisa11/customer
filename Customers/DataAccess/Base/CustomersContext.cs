using Customers.Entitites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Customers.DataAccess.Base
{
	public class CustomersContext : DbContext
	{
		public CustomersContext(DbContextOptions<CustomersContext> options)
	   : base(options)	{ }

		public DbSet<Customer> Customers { get; set; }
	}
}
