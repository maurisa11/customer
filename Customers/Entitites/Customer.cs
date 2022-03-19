using System;

namespace Customers.Entitites
{
    public class Customer : GenericEntity
    {
        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public Gender Gender { get; set; }
    }

    public enum Gender
    {
        Male = 0,
        Female = 1,
        Trans = 2
    }
}
