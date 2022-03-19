using Customers.DataAccess.Base;
using Customers.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customers.DataAccess.UnitOfWorks
{
	public class CustomerUnitOfWork : UnitOfWorkBase
	{
		private IGenericRepository<Customer> customerRepository;

		public CustomerUnitOfWork(CustomersContext context) 
			: base(context)
		{
		}

		public IGenericRepository<Customer> CustomerRepository
		{
			get
			{
				if (customerRepository == null)
				{
					customerRepository = new GenericRepository<Customer>(Context);
				}
				return customerRepository;
			}
		}
	}

}
