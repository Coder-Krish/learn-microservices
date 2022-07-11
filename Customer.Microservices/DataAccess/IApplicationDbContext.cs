using Microsoft.EntityFrameworkCore;

namespace Customer.Microservices.DataAccess
{
    public interface IApplicationDbContext
    {
        DbSet<Entities.Customer> Customers { get; set; }
        Task<int> SaveChanges();
    }
}
