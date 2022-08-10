using EDMSolution.ViewModels;
using EDMSolution.ViewModels.Catalog.Products.Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EDMSolution.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetProductPagingRequest request);
        Task<List<ProductViewModel>> GetAll();
    }
}
