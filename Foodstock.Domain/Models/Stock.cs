using System.ComponentModel.DataAnnotations.Schema;
using Foodstock.Domain.Enums;

namespace Foodstock.Domain.Models
{
    [Table("Stock")]
    public class Stock
    {
        public int Id { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        public StockTypeEnum StockTypeId { get; set; }
        public decimal Value { get; set; }
    }
}
