using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.ViewModels.Catalog.Products
{
    public class GetManageProductPaginRequest : PagingRequestBase
    {
        public string keyword { set; get; }
        public List<int> CategoryIds { set; get; }
    }
}
