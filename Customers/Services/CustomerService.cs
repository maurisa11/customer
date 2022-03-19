using Customers.Entitites;
using Customers.Interfaces;
using System.Collections.Generic;
using Customers.DataAccess.UnitOfWorks;

namespace Customers.Services
{
	public class CustomerService : ICustomerService
	{
		private readonly CustomerUnitOfWork unitOfWork;
		public CustomerService(CustomerUnitOfWork unitOfWork)
		{
			this.unitOfWork = unitOfWork;

		}
		public bool Create(Customer customer)
		{
            return unitOfWork.CustomerRepository.Insert(customer);
		}
	}
}
