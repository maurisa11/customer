using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Customers.Entitites
{
	public abstract class GenericEntity
	{
		[Key, Column(Order = 0)]
		public int Id { get; set; }
	}
}
