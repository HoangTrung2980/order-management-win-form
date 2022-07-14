#nullable disable

using System.ComponentModel.DataAnnotations.Schema;

namespace ProductDBEntityFramework.Models
{
    public partial class OrderDetail
    {
        private int _id;
        private int _productId;
        private int _orderId;
        private int _quantity;
        private double _price;

        public OrderDetail()
        {
            this._id = 0;
            this._productId = 0;
            this._orderId = 0;
            this._quantity = 0;
            this._price = 0.0;
        }

        public OrderDetail(int id, int? productId, int? orderId, int? quantity, double? price)
        {
            Id = id;
            ProductId = productId;
            OrderId = orderId;
            Quantity = quantity;
            Price = price;
        }

        //public OrderDetail(int id, int productId, int orderId, int quantity, double price)
        //{
        //    this._id = id;
        //    this._productId = productId;
        //    this._orderId = orderId;
        //    this._quantity = quantity;
        //    this._price = price;
        //}

        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int? OrderId { get; set; }
        public int? Quantity { get; set; }
        public double? Price { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
