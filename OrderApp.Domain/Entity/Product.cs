using System.ComponentModel.DataAnnotations;

namespace OrderApp.Domain.Entity
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(63, ErrorMessage = "Name is too long")]
        public string Name { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public float Price { get; set; }

        [Required]
        public int OrderId { get; set; }

        public Order Order { get; set; }
    }
}