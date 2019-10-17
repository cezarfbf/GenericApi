using ApplicationCore.Domain.Entities;
using ApplicationCore.Persistence;
using ApplicationCore.Repositories.Common;
using ApplicationCore.Repositories.Interfaces;
using ApplicationCore.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ApplicationCore.Repositories.Implementations
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(DefaultDbContext context) : base(context)
        {

        }

        public DefaultDbContext DefaultDbContext { get { return Context as DefaultDbContext; } }

        public async Task<Product> GetProductAsync(int id)
        {
            return await DefaultDbContext.Products.FirstOrDefaultAsync(p => p.Id == id);
        }

    }
}
