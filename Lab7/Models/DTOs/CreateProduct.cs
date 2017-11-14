using System;

namespace Lab7.Models.DTOs
{
    public class CreateProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime StartDate { get; set; }
    }
}
