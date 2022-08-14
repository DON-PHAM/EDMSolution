using EDMSolution.Data.EF;
using EDMSolution.ViewModels;
using EDMSolution.ViewModels.Catalog.Products;
using Microsoft.EntityFrameworkCore;
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

        public async Task<List<ProductViewModel>> GetAll()
        {
            var query = from p in _context.Products
                        join pt in _context.ProductTranslations on p.ID equals pt.ProductID
                        select new { p, pt };
            var data = await query.Select(x => new ProductViewModel()
            {
                ID = x.p.ID,
                Name = x.pt.Name,
            }).ToListAsync();
            return data;
        }

        public Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetPublicProductPagingRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
