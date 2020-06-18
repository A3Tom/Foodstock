using System.ComponentModel.DataAnnotations.Schema;

namespace Foodstock.Domain.Models
{
    [Table("Product")]
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]

        public Category Catgeory { get; set; }
    }
}
