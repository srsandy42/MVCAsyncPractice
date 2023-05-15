using System.ComponentModel.DataAnnotations;

namespace MvcasyncProject.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string? ProductName { get; set; }

        [StringLength(100)]
        public string? Description { get; set; }
        public decimal? Price { get; set; }

        [Required]
        public string? Category { get; set; }
    }
}
