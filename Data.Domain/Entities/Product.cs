using System;
using EnsureThat;

namespace Data.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public double Price { get; private set; }
        public DateTime StartDate { get; private set; }

        public static Product Create(string name, double price, DateTime startDate)
        {
            Ensure.That(name).IsNotNullOrEmpty();
            var instance = new Product { Id = Guid.NewGuid() };
            instance.Update(name, price, startDate);
            return instance;
        }

        public void Update(string name, double price, DateTime startDate)
        {
            Ensure.That(name).IsNotNullOrEmpty();
            Name = name;
            Price = price;
            StartDate = startDate;
        }
    }
}
