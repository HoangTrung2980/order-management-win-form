using System;
using System.Collections.Generic;

#nullable disable

namespace ProductDBEntityFramework.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double? Price { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? Status { get; set; }
        public int? CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
