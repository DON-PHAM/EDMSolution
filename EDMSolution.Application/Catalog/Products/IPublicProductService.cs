using EDMSolution.Application.Catalog.Products.Dtos;
using EDMSolution.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetProductPagingRequest = EDMSolution.Application.Catalog.Products.Dtos.Public.GetProductPagingRequest;

namespace EDMSolution.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetProductPagingRequest request);
    }
}
