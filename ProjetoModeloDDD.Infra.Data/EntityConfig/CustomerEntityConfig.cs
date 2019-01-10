using ProjetoModeloDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoModeloDDD.Infra.Data.EntityConfig
{
    public class CustomerEntityConfig : EntityTypeConfiguration<Customer>
    {
        public CustomerEntityConfig()
        {
            HasKey(c => c.CustomerId);

            Property(c => c.FirstName)
                .IsRequired()
                .HasMaxLength(30);

            Property(c => c.LastName)
                .IsRequired()
                .HasMaxLength(50);

            Property(c => c.Email)
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}
