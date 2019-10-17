using System.Threading.Tasks;
using ApplicationCore.Business.Interfaces;
using ApplicationCore.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GenericApi.Controllers
{

    public class ProductController : BaseController
    {
        private readonly IProductBusiness _productBusiness;
        public ProductController(IProductBusiness productBusiness)
        {
            _productBusiness = productBusiness;
        }
        

        //[HttpGet()]
        //public async Task<ActionResult<ProductVm>> GetAll()
        //{
        //    return Ok(await Mediator.Send(new GetProductsListQuery()));
        //}

        //[HttpGet]
        //public async Task<FileResult> Download()
        //{
        //    var vm = await Mediator.Send(new GetProductsFileQuery());

        //    return File(vm.Content, vm.ContentType, vm.FileName);
        //}

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductVm>> Get(int id)
        {
            return Ok(await _productBusiness.GetProductAsync(id));
        }

        //[HttpPost]
        //public async Task<ActionResult<int>> Create([FromBody] CreateProductCommand command)
        //{
        //    var productId = await Mediator.Send(command);

        //    return Ok(productId);
        //}

        //[HttpPut]
        //[ProducesResponseType(StatusCodes.Status204NoContent)]
        //[ProducesDefaultResponseType]
        //public async Task<IActionResult> Update([FromBody] UpdateProductCommand command)
        //{
        //    await Mediator.Send(command);

        //    return NoContent();
        //}

        //[HttpDelete("{id}")]
        //[ProducesResponseType(StatusCodes.Status204NoContent)]
        //[ProducesDefaultResponseType]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    await Mediator.Send(new DeleteProductCommand { Id = id });

        //    return NoContent();
        //}
    }
}