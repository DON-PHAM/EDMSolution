using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.ViewModels.Catalog.Products
{
    public class ProductImageViewModel
    {
        public int ID { set; get; }
        public string FilePath { set; get; }
        public bool IsDefault { set; get; }
        public long FileSize { set; get; }
        public IFormFile ImageFile { set; get; }
    }
}
