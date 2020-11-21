using Abp.AutoMapper;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using Abp.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vino.ByProduct.Dto;
using vino.Products;

namespace vino.ByProduct
{
    public class ProductAppService : vinoAppServiceBase, IProductAppService
    {
        private readonly IRepository<Product> _productRepository;

        public ProductAppService(IRepository<Product> ProductRepository)
        {
            _productRepository = ProductRepository;
        }

        [Obsolete]
        public List<ProductListDto> GetProducts(GetProductInput input)
        {
            var query = _productRepository
                .GetAll()
                .WhereIf(
                    !input.Filter.IsNullOrEmpty(),
                    p => p.Id.ToString().Contains(input.Filter) ||
                        p.Code.Contains(input.Filter) ||
                         p.Name.Contains(input.Filter) ||
                         p.Description.Contains(input.Filter)
                )
                .OrderBy(p => p.CreationTime)
                .ThenBy(p => p.Name)
                .ToList();

            return new List<ProductListDto>(query.MapTo<List<ProductListDto>>());
        }

    }
}
