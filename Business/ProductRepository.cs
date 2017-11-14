using System;
using System.Collections.Generic;
using System.Linq;
using Data.Domain.Entities;
using Data.Domain.Interfaces;
using Data.Persistence;

namespace Business
{
    public class ProductRepository : IProductRepository
    {
        private readonly DatabaseContext _dbContext;

        public ProductRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Product product)
        {
            _dbContext.Add(product);
            _dbContext.SaveChanges();
        }
        
        public void Update(Product product)
        {
            _dbContext.Update(product);
            _dbContext.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var product = Get(id);
            _dbContext.Remove(product);
            _dbContext.SaveChanges();
        }
        
        public IReadOnlyCollection<Product> GetAll()
        {
            return _dbContext.Products.ToList();
        }

        public Product Get(Guid? id)
        {
            return _dbContext.Products.FirstOrDefault(p => p.Id == id);
        }

        public bool Exists(Guid id)
        {
            return _dbContext.Products.Any(p => p.Id == id);
        }
    }
}
