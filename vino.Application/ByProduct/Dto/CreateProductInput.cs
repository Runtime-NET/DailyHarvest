using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using vino.Products;

namespace vino.ByProduct.Dto
{
    [AutoMapTo(typeof(Product))]
    public class CreateProductInput
    {
        [Required]
        public virtual string Code { get; set; }

        [Required]
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual decimal Price { get; set; }
        public virtual string ImagePath { get; set; }

    }
}
