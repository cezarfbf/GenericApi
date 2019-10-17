using ApplicationCore.Common.Interfaces;
using ApplicationCore.Domain.Entities;

namespace ApplicationCore.ViewModels
{
    public class ProductVm : IMapFrom<Product>
    {
        public int Id { get; set; }

        public string ProductName { get; set; }
    }
}
