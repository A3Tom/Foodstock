using System.ComponentModel.DataAnnotations.Schema;

namespace Foodstock.Domain.Models
{
    [Table("MenuItem")]
    public class MenuItem
    {
        public int Id { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Catgeory { get; set; }
        public int Position { get; set; }
    }
}
