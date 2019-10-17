using ApplicationCore.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Business.Interfaces
{
    public interface IProductBusiness
    {
        Task<ProductVm> GetProductAsync(int id);
    }
}
