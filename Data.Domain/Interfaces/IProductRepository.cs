using System;
using System.Collections.Generic;
using Data.Domain.Entities;

namespace Data.Domain.Interfaces
{
    public interface IProductRepository
    {
        void Add(Product product);
        void Update(Product product);
        void Delete(Guid id);
        IReadOnlyCollection<Product> GetAll();
        Product Get(Guid? id);
        bool Exists(Guid id);
    }
}
