using EDMSolution.ViewModels;
using EDMSolution.ViewModels.Catalog.Products;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);
        Task<int> Update(ProductUpdateRequest request);
        Task<ProductViewModel> GetByIDProduct(int productID,string LanguageCode);
        Task<bool> UpdatePrice(int productId, decimal newPrice);
        Task AddViewCount(int productId);
        Task<int> Delete(int productId);
        Task<PagedResult<ProductViewModel>> GetAllPaging(GetManageProductPaginRequest request);
        Task<int> AddImages(int productID, ProductImageViewModel productImage);
        Task<int> RemoveImages(int imageId);
        Task<int> UpdateImages(int imageId, ProductImageViewModel productImage);
        Task<List<ProductImageViewModel>> GetListImage(int productID);
    }
}
