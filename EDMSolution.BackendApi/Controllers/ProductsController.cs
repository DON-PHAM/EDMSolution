using EDMSolution.Application.Catalog.Products;
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
        public ProductsController(IPublicProductService publicProductService)
        {
            _publicProductService = publicProductService;
        }
        [HttpGet("getallproduct")]
        public async Task<IActionResult> GetAllProduct()
        {
            try
            {
                var product = await _publicProductService.GetAll();
                if (product == null)
                {
                    return BadRequest();
                }
                return Ok(product);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
            }
            
    }
}
