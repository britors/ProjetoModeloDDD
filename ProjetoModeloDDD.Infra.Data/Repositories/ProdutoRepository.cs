using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Product>
    {
        public IEnumerable<Product> GetByName(string name)
        {
            return Db.Products.AsNoTracking().Where(p => p.Name.Equals(name));
        }
    }
}
