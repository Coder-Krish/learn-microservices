using Microsoft.EntityFrameworkCore;

namespace Product.Microservices.DataAccess
{
    public interface IApplicationDbContext
    {
        DbSet<Entities.Product> Products { get; set; }
        Task<int> SaveChanges();
    }
}
