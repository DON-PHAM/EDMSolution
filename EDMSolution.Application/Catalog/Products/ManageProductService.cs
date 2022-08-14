using EDMSolution.Application.Common;
using EDMSolution.Data.EF;
using EDMSolution.Data.Entities;
using EDMSolution.Utilities.Exceptions;
using EDMSolution.ViewModels;
using EDMSolution.ViewModels.Catalog.Products;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.Application.Catalog.Products
{
    public class ManageProductService : IManageProductService
    {
        private readonly EDMDbContext _context;
        private readonly IStorageService _storageService;
        public ManageProductService(EDMDbContext context, IStorageService storageService)
        {
            _context = context;
            _storageService = storageService;
        }

        public Task<int> AddImages(int productID, ProductImageViewModel productImage)
        {
            throw new NotImplementedException();
        }

        public async Task AddViewCount(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            product.ViewCount += 1;
            await _context.SaveChangesAsync();
        }

        public async Task<int> Create(ProductCreateRequest request)
        {
            var product = new Product()
            {
                Price = request.Price,
                ProductTranslations = new List<ProductTranslation>()
                {
                    new ProductTranslation()
                    {
                        Name = request.Name,
                        LanguageCode = request.LanguageCode,
                    }
                }
            };
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product.ID;
        }

        public async Task<int> Delete(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null) throw new EDMException($"Cannot find a product: {productId}");
            _context.Products.Remove(product);
            return await _context.SaveChangesAsync();
        }
        public async Task<PagedResult<ProductViewModel>> GetAllPaging(GetManageProductPaginRequest request)
        {
            var query = from p in _context.Products
                        join pt in _context.ProductTranslations on p.ID equals pt.ProductID
                        select new { p , pt};
            if (!string.IsNullOrEmpty(request.keyword))
                query = query.Where(x => x.pt.Name.Contains(request.keyword));
            int totalRow = await query.CountAsync();
            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                        .Take(request.PageSize)
                        .Select(x =>new ProductViewModel() { 
                            ID = x.p.ID,
                            Name = x.pt.Name,
                            Description = x.pt.Description,
                            LanguageCode = x.pt.LanguageCode
                        }).ToListAsync();
            var pageResult = new PagedResult<ProductViewModel>()
            {
                TotalRecord = totalRow,
                Items = data,
            };
            return pageResult;
        }

        public async Task<ProductViewModel> GetByIDProduct(int productID, string LanguageCode)
        {
            var product = await _context.Products.FindAsync(productID);
            var productTranslation = await _context.ProductTranslations.FirstOrDefaultAsync(x => x.ProductID == productID && x.LanguageCode == LanguageCode); 
            var productViewModel = new ProductViewModel()
            {
                ID = product.ID,
                CreatedDate = product.CreatedDate,
                Description = productTranslation != null ? productTranslation.Description : null,
                LanguageCode = productTranslation.LanguageCode,
                Name = productTranslation != null ? productTranslation.Name : null,
            };
            return productViewModel;

        }

        public Task<List<ProductImageViewModel>> GetListImage(int productID)
        {
            throw new NotImplementedException();
        }

        public Task<int> RemoveImages(int imageId)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Update(ProductUpdateRequest request)
        {
            var product = await _context.Products.FindAsync(request.ID);
            var productTranslation = await _context.ProductTranslations.FirstOrDefaultAsync(x => x.ProductID == request.ID && x.LanguageCode == request.LanguageCode);
            if (product == null || productTranslation == null) throw new EDMException($"Cannot find a product with ID: {request.ID}");
            productTranslation.Name = request.Name;
            productTranslation.MetaKeywords = request.MetaKeywords;
            productTranslation.MetaDescription = request.MetaDescription;
            productTranslation.Description = request.Description;
            return await _context.SaveChangesAsync();
        }
        public Task<int> UpdateImages(int imageId, ProductImageViewModel productImage)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdatePrice(int productId, decimal newPrice)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null) throw new EDMException($"Cannot find a product with ID:{productId}");
            product.Price = newPrice;
            return await _context.SaveChangesAsync() > 0;
        }

        private async Task<string> SaveFile(IFormFile file)
        {
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
            await _storageService.SaveFileAsync(file.OpenReadStream(),fileName);
            return fileName;
        }
    }
}
