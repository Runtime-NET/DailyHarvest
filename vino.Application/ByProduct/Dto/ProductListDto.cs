using System.Collections.ObjectModel;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using vino.Products;

namespace vino.ByProduct.Dto
{
    [AutoMapFrom(typeof(Product))]
    public class ProductListDto : FullAuditedEntityDto
    {
        public virtual string Code { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual decimal Price { get; set; }
        public virtual string ImagePath { get; set; }

    }
}
