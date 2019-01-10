using System.Collections.Generic;
using ProjetoModeloDDD.Application.Interfaces;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Services;

namespace ProjetoModeloDDD.Application
{
    public class ProductAppService : AppServiceBase<Product>, IProductAppService
    {
        private readonly IProductService _productService;

        public ProductAppService(IProductService productService)
            :base(productService)
        {
            _productService = productService;
        }

        public IEnumerable<Product> GetByName(string name)
        {
            return _productService.GetByName(name);
        }
    }
}
