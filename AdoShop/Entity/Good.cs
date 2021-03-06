﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace AdoShop.Entity
{
    [Table("goods")]
    public class Good
    {
        public Good()
        {
            Orders = new HashSet<OrderRelatedGoods>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Column("supplier_id")]
        public int? SupplierId { get; set; }

        [Column("category_id")]
        public int? CategoryId { get; set; }

        [Column("price")]
        [Required]
        public decimal Price { get; set; }

        [Column("count")]
        [Required]
        public int Count { get; set; }

        [JsonIgnore]
        public virtual Category Category { get; set; }

        [JsonIgnore]
        public virtual Supplier Supplier { get; set; }

        [JsonIgnore]
        public virtual ICollection<OrderRelatedGoods> Orders { get; set; }
    }
}
