using Domain.EnitityInterfaces;
using Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Bike : IBike
    {
        [Key, Required]
        public int Id { get; set; }
        [Required, MinLength(1), MaxLength(100)]
        public string Title { get; set; }
        [Required]
        public Type Type { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public Status Status { get; set; }
    }
}