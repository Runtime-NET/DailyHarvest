using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vino.ByProduct.Dto;

namespace vino.ByProduct
{
    public interface IProductAppService : IApplicationService
    {
        List<ProductListDto> GetProducts(GetProductInput input);
    }
}
