using System.Collections.Generic;
using System.Linq;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Product>, IProductRepository
    {
        public IEnumerable<Product> GetByName(string name)
        {
            return Db.Product.AsNoTracking().Where(p => p.Name.Equals(name));
        }
    }
}
