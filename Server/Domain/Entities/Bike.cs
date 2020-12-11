using Domain.EnitityInterfaces;
using Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Bike : IBike
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public Type Type { get; set; }
        public decimal Price { get; set; }
        public Status Status { get; set; }
    }
}