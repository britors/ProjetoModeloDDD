using System;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime InsertAt { get; set; }
        public bool Actived { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public bool IsOldCustomer(Customer customer)
        {
            return customer.Actived && DateTime.Now.Year - customer.InsertAt.Year >= 5;
        }
    }
}
