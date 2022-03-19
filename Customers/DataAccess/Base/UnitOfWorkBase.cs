using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customers.DataAccess.Base
{
	public abstract class UnitOfWorkBase : IDisposable
	{
		private bool disposed = false;

		public CustomersContext Context { get; }

		public UnitOfWorkBase(CustomersContext context)
		{
			Context = context;
		}

		public void Save()
		{
			Context.SaveChanges();
		}

		protected virtual void Dispose(bool disposing)
		{
			if (!disposed)
			{
				if (disposing)
				{
					Context.Dispose();
				}
			}
			disposed = true;
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
	}
}
