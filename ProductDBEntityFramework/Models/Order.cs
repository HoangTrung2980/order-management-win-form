using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace ProductDBEntityFramework.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new List<OrderDetail>(); // Change from HashSet to List to support indexing
            Payments = new List<Payment>(); // Change from HashSet to List to support indexing
        }


        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public double? Price { get; set; }
        public DateTime? OrderDate { get; set; }
        public int? Status { get; set; }

        public virtual IList<OrderDetail> OrderDetails { get; set; } // Change from ICollection to IList to support indexing
        public virtual IList<Payment> Payments { get; set; } // Change from ICollection to IList to support indexing
    }
}
