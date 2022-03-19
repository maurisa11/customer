using Customers.Entitites;
using System.Collections.Generic;

namespace Customers.Interfaces
{
	public interface ICustomerService
	{
		bool Create(Customer customer);
	}

}
