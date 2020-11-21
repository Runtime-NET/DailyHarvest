using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace vino.Products
{
    [Table("Product")]
    public class Product : FullAuditedEntity
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
