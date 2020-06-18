using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Foodstock.Domain.Models
{
    [Table("TransactionLog")]
    public class TransactionLog
    {
        public int Id { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        [ForeignKey("Stock")]
        public int StockId { get; set; }
        [ForeignKey("StockId")]
        public Product Stock { get; set; }
        public decimal ValueChange { get; set; }
        public DateTimeOffset Timestamp { get; }
    }
}
