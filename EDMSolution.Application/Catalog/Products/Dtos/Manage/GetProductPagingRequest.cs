using EDMSolution.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.Application.Catalog.Products.Dtos
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public string keyword { set; get; }
        public List<int> CategoryIds { set; get; }
    }
}
