using System.ComponentModel.DataAnnotations.Schema;

namespace Foodstock.Domain.Models
{
    [Table("Category")]
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
    }
}
