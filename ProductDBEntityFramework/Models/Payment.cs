using System;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace ProductDBEntityFramework.Models
{
    public partial class Payment
    {
        private int _id;
        private DateTime _payTime = DateTime.Today;
        private double _amount;
        private string _payType;
        private int _orderId;

        public Payment()
        {
            this._id = 0;
            this._payTime = DateTime.Today;
            this._amount = 0.0;
            this._payType = "";
            this._orderId = 0;
        }

        public Payment(int id, DateTime? payTime, double? amount, string payType, int? orderId)
        {
            Id = id;
            PayTime = payTime;
            Amount = amount;
            PayType = payType;
            OrderId = orderId;
        }

        //public Payment(int id, DateTime payTime, double amount, string payType, int orderId)
        //{
        //    this._id = id;
        //    this._payTime = payTime;
        //    this._amount = amount;
        //    this._payType = payType;
        //    this._orderId = orderId;
        //}

        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime? PayTime { get; set; }
        public double? Amount { get; set; }
        public string PayType { get; set; }
        public int? OrderId { get; set; }

        public virtual Order Order { get; set; }
    }
}
