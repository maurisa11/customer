using Customers.Entitites;
using Customers.Interfaces;
using Customers.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Customers.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService customerService;
        public CustomersController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        [HttpPost("[action]")]
        public IActionResult Create([FromBody] CustomerModel model)
        {
            try
            {
                if (model == null)
                {
                    return BadRequest();
                }

                // It's better use Automapper
                var entity = new Customer()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Address = model.Address,
                    Email = model.Email,
                    Gender = (Gender)model.Gender
                };

                var result = this.customerService.Create(entity);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return Ok(false);
            }
        }
    }
}
