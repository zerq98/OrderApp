using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OrderApp.Domain.Entity
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(63, ErrorMessage = "Name is too long")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(63, ErrorMessage = "Surname is too long")]
        public string Surname { get; set; }

        [Required]
        public string BirthDate { get; set; }

        public DateTime DateOfOrder { get; set; }
        public List<Product> Products { get; set; }
    }
}