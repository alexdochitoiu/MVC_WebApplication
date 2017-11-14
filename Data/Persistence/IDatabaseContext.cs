using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Persistence
{
    public interface IDatabaseContext
    {
        DbSet<Product> Products { get; set; }
        int SaveChanges();
    }
}