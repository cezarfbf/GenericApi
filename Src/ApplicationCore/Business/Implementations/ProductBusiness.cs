using ApplicationCore.Business.Interfaces;
using ApplicationCore.Repositories.Interfaces;
using ApplicationCore.ViewModels;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Business.Implementations
{
    public class ProductBusiness : IProductBusiness
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductBusiness(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        //public async Task<ProductVm> GetAll()
        //{
        //    var products = _productRepository.GetAll();
        //    CancellationToken cancellationToken
        //    var vm = await _context.Products
        //        .ProjectTo<ProductDetailVm>(_mapper.ConfigurationProvider)
        //        .FirstOrDefaultAsync(p => p.ProductId == request.Id, cancellationToken);

        //    if (vm == null)
        //    {
        //        throw new NotFoundException(nameof(Product), request.Id);
        //    }

        //    return vm;
        //}

        public async Task<ProductVm> GetProductAsync(int id)
        {
            try
            {
                var product = await _productRepository.GetProductAsync(id);
                return _mapper.Map<ProductVm>(product);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
