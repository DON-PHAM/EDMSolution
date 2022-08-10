using EDMSolution.Application.Catalog.Products;
using EDMSolution.ViewModels;
using EDMSolution.ViewModels.Catalog.Products.Public;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDMSolution.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IPublicProductService _publicProductService;
        private readonly IManageProductService _manageProductService;
        public ProductsController(IPublicProductService publicProductService, IManageProductService manageProductService)
        {
            _publicProductService = publicProductService;
            _manageProductService = manageProductService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllProduct()
        {
            var products = await _publicProductService.GetAll();
            if (products == null)
                return BadRequest();
            return Ok(products);
        }
        [HttpGet("public-paging")]
        public async Task<IActionResult> GetAllProduct([FromQuery]GetProductPagingRequest request)
        {
            var products = await _publicProductService.GetAllByCategoryId(request);
            return Ok(products);
        }
        [HttpGet("{languageID}/{productID}")]
        public async Task<IActionResult> GetById(int productID, int languageID)
        {
            var product = await _manageProductService.GetByIDProduct(productID,languageID);
            if (product == null)
                return BadRequest("Cannot find Product");
            return Ok(product);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromForm] ProductCreateRequest request)
        {
            var productID = await _manageProductService.Create(request);
            if (productID == 0)
                return BadRequest();
            var product = await _manageProductService.GetByIDProduct(productID, request.LanguageID);
            return CreatedAtAction(nameof(GetById),new { id = productID}, product);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromForm] ProductUpdateRequest request)
        {
            var affectedResult = await _manageProductService.Update(request);
            if (affectedResult == 0)
                return BadRequest();
            return Ok();
        }
        [HttpDelete("productID")]
        public async Task<IActionResult> Delete(int productID)
        {
            var affectedResult = await _manageProductService.Delete(productID);
            if (affectedResult == 0)
                return BadRequest();
            return Ok();
        }
        [HttpPut("{productID}/{newPrice}")]
        public async Task<IActionResult> UpdatePrice([FromQuery]int productID, decimal newPrice)
        {
            var isSuccessFul = await _manageProductService.UpdatePrice(productID, newPrice);
            if (isSuccessFul == false)
                return BadRequest();
            return Ok();
        }
    }
}
