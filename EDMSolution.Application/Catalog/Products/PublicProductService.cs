using EDMSolution.Data.EF;
using EDMSolution.ViewModels;
using EDMSolution.ViewModels.Catalog.Products.Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.Application.Catalog.Products
{
    public class PublicProductService : IPublicProductService
    {
        private readonly EDMDbContext _context;
        public PublicProductService(EDMDbContext context)
        {
            _context = context;
        }

        public async Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetProductPagingRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
