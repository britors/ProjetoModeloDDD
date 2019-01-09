using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoModeloDDD.Domain.Entities
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [StringLength(30)]        
        public string FirstName { get; set; }
        [StringLength(50)]
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
