using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.Application.Catalog.Products.Dtos
{
    public class ProductCreateRequest
    {
        public string Name { set; get; }
        public decimal Price { set; get; }
    }
}
